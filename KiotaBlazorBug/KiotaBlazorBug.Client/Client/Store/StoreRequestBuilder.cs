// <auto-generated/>
#pragma warning disable CS0618
using KiotaBlazorBug.Client.Store.Inventory;
using KiotaBlazorBug.Client.Store.Order;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace KiotaBlazorBug.Client.Store
{
    /// <summary>
    /// Builds and executes requests for operations under \store
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StoreRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The inventory property</summary>
        public global::KiotaBlazorBug.Client.Store.Inventory.InventoryRequestBuilder Inventory
        {
            get => new global::KiotaBlazorBug.Client.Store.Inventory.InventoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The order property</summary>
        public global::KiotaBlazorBug.Client.Store.Order.OrderRequestBuilder Order
        {
            get => new global::KiotaBlazorBug.Client.Store.Order.OrderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaBlazorBug.Client.Store.StoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StoreRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/store", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaBlazorBug.Client.Store.StoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StoreRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/store", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618