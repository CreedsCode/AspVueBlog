<template>
    <div class="col-md-8 blog-main">
        <h3 class="pb-4 mb-4 font-italic border-bottom">
            From the Firehose
        </h3>

        <div v-for="post in posts" v-bind:key="post.id">
            <Post :post="post" /><!-- /.blog-post -->
        </div>

        <nav class="blog-pagination">
            <a class="btn btn-outline-primary" href="#">Older</a>
            <a class="btn btn-outline-secondary disabled" href="#" tabindex="-1" aria-disabled="true">Newer</a>
        </nav>

    </div>
</template>
<script>
    import Post from "@/components/Post"
    export default {
        name: 'BlogMain',
    props:{
        posts:Object
    },
        data() {
            return {
                errors: []
            }
        },
        components: {Post}
    }
</script>
<style>

    @media (min-width: 768px) {
    }
</style>