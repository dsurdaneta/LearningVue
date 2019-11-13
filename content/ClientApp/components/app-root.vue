<template>
    <div id="app" class="container-fluid">
        <aside class="row">
            <aside class="col-md-3">
                <nav-menu params="route: route"></nav-menu>
            </aside>
            <section class="col-sm-9">
                <router-view></router-view>
            </section>
        </aside>
    </div>
</template>

<script>
    import NavMenu from './nav-menu'

    export default {
      components: {
        'nav-menu': NavMenu
      },

      data () {
        return {}
      }
    }
</script>

<style>
</style>
