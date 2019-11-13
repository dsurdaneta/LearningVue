<template>
    <div id="app" class="container-fluid">
        <main class="row">
            <aside class="col-md-3">
                <nav-menu params="route: route"></nav-menu>
            </aside>
            <article class="col-sm-9">
                <router-view></router-view>
            </article>
        </main>
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
