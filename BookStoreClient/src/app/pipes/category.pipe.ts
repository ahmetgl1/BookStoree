import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'category'
})
export class CategoryPipe implements PipeTransform {

  
  transform(value: any[], search: string): any[] {
    if (!value || !search) {
      return value;
    }

    return value.filter(category => category.name.toLowerCase().includes(search.toLowerCase()));
  }
}
