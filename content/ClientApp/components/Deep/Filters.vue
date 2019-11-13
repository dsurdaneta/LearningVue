<template>
  <div>
    <h1 v-once>{{msg}}</h1>
    <h3>Creating Filters</h3>
    <p>{{test | AllCaps}}</p>
    <h3>Filters in v-bind</h3>
    <input type="text" v-bind:value="test" />
  </div>
</template>

<script>
  export default {
    data() {
      return {
        msg:'Filters',
        test: 'test'
      }
    },
    methods: {
      Update: function () {
        this.msg = 'test';
      }
    },
    filters: {
      AllCaps: function (val) {
        if (val != '') {
          console.log('will be capital: '+val)
          return val.toUpperCase();
        }
        return '';
      },
      AllSmall: function (val) {
        if (val != '') {
          console.log('will be small: '+val)
          return val.toLowerCase();
        }
        return '';
      },
    }
  }

</script>

<style>

</style>
