<template>
    <div>
        <div class="container">
            <Header/>
            <CategoryBar/>
            <MainFeaturedPost :post="this.featuredPost"/>

            <SecondFeaturedPosts/>
        </div>

        <main role="main" class="container">
            <div class="row">
                <BlogMain :posts="this.posts"/><!-- /.blog-main -->
                <SideBar/><!-- /.blog-sidebar -->

        </div><!-- /.row -->
        </main><!-- /.container -->

    </div>

</template>

<script>
    import MainFeaturedPost from "@/components/MainFeaturedPost";
    import SecondFeaturedPosts from "@/components/SecondFeaturedPosts";
    import BlogMain from "@/components/BlogMain";
    import SideBar from "@/components/SideBar";
    import axios from "axios";
    export default {
        name: "IndexPage",
        data() {
            return {
                posts: [],
                featuredPost:null,
                errors: []
            }
        },
        components: {
            SideBar,
            BlogMain,
            SecondFeaturedPosts,
            MainFeaturedPost
        },
        beforeCreate() {
            axios.get(`https://localhost:5001/api/posts`)
                .then(response => {
                    // JSON responses are automatically parsed.
                    this.posts = response.data
                })
                .catch(e => {
                    this.errors.push(e.message)
                });
            axios.get(`https://localhost:5001/api/posts?category=featured`)
                .then(response => {
                    // JSON responses are automatically parsed.
                    this.featuredPost = response.data[0]
                })
                .catch(e => {
                    this.errors.push(e.message)
                });
    }}

</script>

<style scoped>

</style>