/*Program in which a string is accepted and a sequence of letters is
checked if present, not necessary consecutive but they must occur in 
the same order as they occur in original string*/



#include <stdio.h>
#include<string.h>

int main() {
    char name[100], tofind[100];
    int i, j=0;
    printf("Enter a string without blank: ");
    scanf("%s", name);
    printf("Enter the letters in sequence to be found: ");
    scanf("%s", tofind);
    for (i=0; i<strlen(tofind); i++)
    {
    for (j=i; j<strlen(name); j++) if (tofind[i]==name[j]) break;
        if (tofind[i]==name[j]) continue;
        else
        {
            printf("\nSequence is not contained!");
            return 0;
        }
    }
    printf("\nSequence is contained!\nString without the sequence is ");
    j=0;
    for (i=0; i<strlen(name); i++)
    {
        if (j<strlen(name))
        {
            if(name[i]==tofind[j]) j++;
            else printf("%c", name[i]);
        }
    }
return 0;
}