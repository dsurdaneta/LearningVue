<template>
  <section>
    <h1>{{msg}}</h1>
    <h3>Computed Properties are a great way to cache data</h3>
    <p>The value is: {{val}}</p>
    <button @click="CallComputed()">Get value</button>
    <br/>
    <h3>Computed properties with get/set</h3>
    <p>{{active}}</p>
    <button @click="updateComputed()">Update Value</button>
  </section>
</template>

<script>
  export default {
    data() {
      return {
        msg: 'Computed properties',
        val: '',
        temp: ''
      }
    },
    methods: {
      CallComputed: function () {
        this.val = this.computedData;
      },
      valueReturn: function () {
        console.log("computed!");
        return "amr";
      },
      updateComputed: function () {
        this.active = "aaaa";
      }
    },
    computed:
    {
      computedData: function () {
        return this.valueReturn();
      },
      active: {
        get: function () {
          return this.temp;
        },
        set: function (value) {
          this.temp = value;
        }
      }
    }
  }
</script>

<style>

</style>
