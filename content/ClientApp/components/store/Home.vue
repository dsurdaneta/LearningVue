<template>
  <section>
    <h1>{{msg}}</h1>
    <h3>Checkout our great items!</h3>
    <div class="row">
      <div v-for="item in Items" class="col-md-4">
        <span style="font-size:large;">{{item.name}}</span> <!--- <span style="font-size:large;color:red;">${{item.price}}</span>-->
      </div>
    </div>
  </section>
</template>

<script>
  export default {
    data() {
      return {
        msg: 'Store Home - Great Store! made with Vue & .net core',
        Items: []
      }
    },
    methods: {
      LoadData: function () {
        try {
          this.$http.get('api/Items').then(result => {
            this.Items = result.data;
            console.log(result);
          })
        } catch (error) {
          console.log(error)
        }
      },
    },
    created() {
      this.LoadData();
    }
  }
</script>

<style>

</style>
