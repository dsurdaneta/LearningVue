<template>
  <div>
    <h1>{{msg}}</h1>
    <h3>Child Route Component</h3>
    <p>This is the child component.</p>
    <p>Your current route is: {{RouteValue}}</p>
  </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Routes - Child Component',
                RouteValue:''

            }
        },
        methods: {

        },
        created: function () {
            this.RouteValue = this.$route.params.id;
        }
    }
</script>

<style>
</style>
