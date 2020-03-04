﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_generic
{
    public interface IVisit<T>
    {
        void visit(T data);
    }
        
    /// <summary>
    /// Класс "Бинарное поисковое дерево"
    /// </summary>
    public class Tree <T> where T : IComparable
    {
        /// <summary>
        /// Класс "узел БПД"
        /// </summary>
        protected class Item
        {
            /// <summary>
            /// info - значение, хранящееся в узле
            /// lSon, rSon, father - ссылки на левого, правого сына и отца
            /// </summary>
            public T info;
            public Item lSon, rSon, father;
            /// <summary>
            /// Конструктор узла БПД
            /// </summary>
            /// <param name="x">значение, хранящееся в узле</param>
            public Item(T x)
            {
                info = x;
                lSon = rSon = father = null;
            }
        }

        /// <summary>
        /// ссылка на корень дерева
        /// </summary>
        private Item root;

        /// <summary>
        /// конструктор дерева
        /// </summary>
        public Tree()
        {
            root = null;
        }

        /// <summary>
        /// внутренняя процедура поиска
        /// </summary>
        /// <param name="x">искомое значение</param>
        /// <param name="p">ели найдено - ссылка на соответствующий узел, иначе - ссылка на то место, где остановились</param>
        /// <returns>нашли или нет</returns>
        private bool Find(T x, out Item p)
        {
            p = root;
            Item q = p;
            while (q != null)
            {
                p = q;
                if ((q.info).CompareTo(x)==0)
                    return true;
                if ((q.info).CompareTo(x) < 0)
                    q = q.rSon;
                else
                    q = q.lSon;
            }
            return false;
        }

        /// <summary>
        /// внешняя процедура поиска
        /// </summary>
        /// <param name="x">искомое значение</param>
        /// <returns>нашли или нет</returns>
        public bool Find(T x)
        {
            Item p;
            return Find(x, out p);
        }

        /// <summary>
        /// втавка в БПД
        /// </summary>
        /// <param name="x">вставляемое значение</param>
        /// <returns>смогли вставить или нет</returns>
        public bool Insert(T x)
        {
            Item r, p;
            if (root == null)
            {
                r= new Item(x);
                root = r;
                return true;
            }
            if (Find(x, out r))
                return false;
            p = new Item(x);
            p.father = r;
            if ((r.info).CompareTo(x) < 0)
                r.rSon = p;
            else
                r.lSon = p;
            return true;
        }

        /// <summary>
        /// удалить вершину (оборвать все ссылки)
        /// </summary>
        /// <param name="x">удаляемая вершина</param>
        private void deleteItem(Item x)
        {
            if (x.father == null)
                if (x.lSon != null) {
                    root = x.lSon;
		    x.lSon.father = null;
		}
            else {
                root = x.rSon;
                if (x.rSon != null)
                    x.rSon.father = null;
            }
        else
            if (x.father.lSon == x)
                if (x.lSon != null) {
                    x.father.lSon = x.lSon;
                    x.lSon.father = x.father;
                }
                else {
                    x.father.lSon = x.rSon;
                    if (x.rSon != null)
                        x.rSon.father = x.father;
                }
            else
                if (x.lSon != null) {
                    x.father.rSon = x.lSon;
                    x.lSon.father = x.father;
                }
                else {
                    x.father.rSon = x.rSon;
                    if (x.rSon != null)
                        x.rSon.father = x.father;
                }
            x.father = x.lSon = x.rSon = null;
        }
        
        /// <summary>
        /// Удалить вершину по значению
        /// </summary>
        /// <param name="x">удаляемое значение</param>
        /// <returns>смогли удалить или нет</returns>
        public bool Delete(T x)
        {
            Item r, p;
            if (!Find(x, out r))
                return false;
            if ((r.lSon == null) || (r.rSon == null))
            {
                deleteItem(r);
                return true;
            }
            p = r.lSon;
            while (p.rSon != null)
                p = p.rSon;
            r.info = p.info;
            deleteItem(p);
            return true;
        }

        protected void SortedLeftTreeWalk(Item p, IVisit <T> v)
        {
            if (p.lSon != null)
                SortedLeftTreeWalk(p.lSon, v);
            v.visit(p.info);
            if (p.rSon != null)
                SortedLeftTreeWalk(p.rSon, v);
        }

        public void SortedLeftTreeWalk(IVisit <T> v)
        {
            SortedLeftTreeWalk(root, v);
        }


    }
}
