// Online C compiler to run C program online
#include <stdio.h>

int arefriends(int x, int y, int N){
    int b[10], c[10];
    int n, i, j, t;
    for(i=0;i<10;i++) {
        b[i] =0;
        c[i]=0;
    }
    for(;x>0;){
        i=x%10;
        x/=10;
        b[i]++;
    }
     for(;y>0;){
        i=y%10;
        y/=10;
        c[i]++;
    }
    for (i=0; i<10; i++)
    {
        if (b[i]==c[i]) t=1;
        else return 0;
    }
    if (t==1) return 1;
    }
   /* for (i=0; x>0 ;i++){
        b[i] = x%10;
        x/=10;
    }
    for (i=0; y>0 ;i++){
        c[i] = y%10;
        y/=10;
    }
    n = i;
    for(i=0; i<n; i++){
        for(j=0; j<n-1; j++){
            if (b[j]>b[j+1]){
                 t = b[j];
                b[j] = b[j+1];
                b[j+1] = t;
            }
        }
    }
    for(i=0; i<n; i++){
        for(j=0; j<n-1; j++){
            if (c[j]>c[j+1]){
                t = c[j];
                c[j] = c[j+1];
                c[j+1] = t;
            }
        }
    }
    for(i=0; i<n; i++){
        if (b[i]==c[i]) t=1;
        else return 0;
    }*/
    


int main() {
const int N;
int i, j;
printf("Enter N: ");
scanf("%d", &N);
int a[N];
printf("Enter elements: ");
for(i=0; i<N; i++) scanf("%d", &a[i]);
for(i=0; i<N-1; i++)
printf("%d", arefriends(a[i], a[i+1], N));

    return 0;
}