<template>
  <div id="app">
      <body>
      <router-view></router-view>

      <footer class="blog-footer">
          <p>Blog template built for <a href="https://getbootstrap.com/">Bootstrap</a> by <a href="https://twitter.com/mdo">@mdo</a>.</p>
          <p>
              <a href="#">Back to top</a>
          </p>
      </footer>


      </body>
  </div>
</template>

<script>
    import Header from "@/components/Header.vue"
    import CategoryBar from "@/components/CategoryBar";
    export default {
        name: 'app',
        data() {
            return {
                posts: [],
                featuredPost: null,
                errors: []
            }
        },
        components: {
            CategoryBar,
            Header
        }
    }
</script>

<style >

    @media (min-width: 768px) {
        .bd-placeholder-img-lg {
            font-size: 3.5rem;
        }
    }
</style>
