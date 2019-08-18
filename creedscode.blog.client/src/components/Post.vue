<template>
    <div class="blog-post">
        <h2 class="blog-post-title">{{post.title}}</h2>
        <p  class="blog-post-meta">{{post.createdDate}} by <a href="#">{{post.author}}</a></p>

        <div v-html="post.content"></div>

    </div>
</template>
<script>
    export default {
        name: 'Post',
        props:{
            post:Object
        }
    }
</script>
<style>

    @media (min-width: 768px) {
    }
</style>