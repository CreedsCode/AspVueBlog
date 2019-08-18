<template>
    <div class="jumbotron p-4 p-md-5 text-white rounded bg-dark">
        <div class="col-md-6 px-0">
            <h1 class="display-4 font-italic">{{this.post.title}}</h1>
            <p class="lead my-3">{{this.post.content}}</p>
            <p class="lead mb-0"><a href="#" class="text-white font-weight-bold">Continue reading...</a></p>
        </div>
    </div>
</template>
<script>
    export default {
        name: 'MainFeaturedPost',
        props:{
            post:Object
        },
        data () {
            return {

            }
        },
        beforeCreate() {

        }
    }
</script>
<style>

    @media (min-width: 768px) {
    }
</style>