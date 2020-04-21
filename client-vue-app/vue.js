
new Vue({
    
    created: function () {
        console.log("hello")
        axios
            .get('https://siposm.hu/api/endpoint.php')
            .then(response => {
                console.log(response.data)
                response.data.forEach(element => {
                    let newNode = document.createElement("p")
                    let textNode = document.createTextNode(element.name)
                    newNode.appendChild(textNode)
                    document.getElementById("users").appendChild(newNode)
                })
            })
    }
})