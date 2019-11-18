<template>
    <main id="app" class="container-fluid">
        <section class="row">
            <header class="col-md-3">
                <nav-menu params="route: route"></nav-menu>
            </header>
            <article class="col-sm-9">
                <router-view></router-view>
            </article>
        </section>
    </main>
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
