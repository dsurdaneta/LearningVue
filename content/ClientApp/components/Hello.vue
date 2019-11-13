<template>
    <article>
      <h1 class="mt-4">
        {{msg}}
      </h1>
      <h2>Student Info</h2>
      <p>Student Name: {{student.name}}</p>
      <p>Student Age: {{student.age}}
      <button @click="UpdateName()">Update Name</button></p>
      {{3 + 5}}
      {{3 > 5}}
      {{student}}
    </article>
</template>

<script>
export default {
  data () {
    return {
      msg: 'Ola k ase',
      student: {
        name: 'Daniel',
        age: 33
      }
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
  h1{
    color:red;
  }
</style>
