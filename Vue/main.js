const app = Vue.createApp({
    data(){
        return {
            cart:0,
            product: 'Dark Chocolate',
            details: ['60% cocoa', '30% sugar', '10% chocolate butter'],
            variants: [
                { id: 2234, type:'dark', image: './assets/images/dark_choc.jpg', quantity: 50 },
                { id: 2235, type:'white', image: './assets/images/white_choc.jpg', quantity: 0 }
            ],
            brand: 'Our Brand',
            selectedVariant:0
        }        
    },
    methods:{
        addToCart(){
            this.cart +=1
        },
        updateVariant(index){
            this.selectedVariant = index
        }
    },
    computed:{
        title(){
            return this.brand + " " + this.product
        },
        image(){
           return this.variants[this.selectedVariant].image
        },
        stock(){
            return this.variants[this.selectedVariant].quantity;
        }
    }
})

