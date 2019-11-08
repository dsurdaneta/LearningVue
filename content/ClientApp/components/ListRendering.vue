<template>
  <div>
    <h1 v-once>
      {{msg}}
    </h1>
    <h3>Rendering a simple list</h3>
    <p v-for="item in Items">
      Id:{{item.Id}}, Name:{{item.Name}}, Status:{{item.Status}}
    </p>
    <h3>Index of the element</h3>
    <p v-for="(item,index) in Items">
      Index:{{index}} - Id:{{item.Id}}, Name:{{item.Name}}, Status:{{item.Status}}
    </p>
    <h3>Iterate through an object</h3>
    <p v-for="(sing,key) in Single">{{key}}: {{sing}}</p>
    <h3>Iterate with a range</h3>
    <ul>
      <li v-for="n in 5">{{n}}</li>
    </ul>
    <h3>Iterate with a condition</h3>
    <ul>
      <li v-for="n in 10" v-if="n % 2 == 0">{{n}}</li>
    </ul>
  </div>
</template>

<script>
export default {
  data () {
    return {
      msg: 'Ola k ase render de listas o k ase?',
      Items: [
        { Id: 1, Name: 'First Item', Status: 'Available'},
        { Id: 2, Name: 'Second Item', Status: 'Out of Stock'},
        { Id: 3, Name: 'Third Item', Status: 'Available'},
        { Id: 4, Name: 'Fourth Item', Status: 'Out of Stock'}
      ],
      Single: { Name: 'Ray', Age: 25 }      
    }
  },
    methods: {
      UpdateName: function () {
        this.student.name = "new Name";
      }
    }
}
</script>

<style>
  h1 {
    color: red;
  }
</style>
