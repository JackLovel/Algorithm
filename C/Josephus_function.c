// 约瑟夫问题
// 2018-11-2

#include <stdlib.h>

typedef struct node *link;
struct node {
  int item;
  link next;
};

int
main(int argc, char * argv[])
{
  int i, N = atoi(argv[1]), M = atoi(argv[2]);
  link t = malloc(sizeof *t), x = t; // 创建一个 t 结点，并为 t 分配一个内存空间
  
  t->item = 1, t->next = t;
  for(i=2, i <= N; i++)
  {
    x = (x->next = malloc(size *x));
    x->item = i; 
    x->next = t;
  }
  
  while(x != x->next)  // 只要还剩最后一个结点，就会一直走下去
  {
    for(i=1; i < M; i++) // 超过第M个结点，就会先执行删除操作。
    {
      x = x->next;
    }
    x->next = x->next->next;    // 删除一个 出局的 节点
    N--;  // 链表长度减一
  }
}
