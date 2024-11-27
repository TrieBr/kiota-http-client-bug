// <auto-generated/>
#pragma warning disable CS0618
using KiotaBlazorBug.Client.Models;
using KiotaBlazorBug.Client.User.CreateWithList;
using KiotaBlazorBug.Client.User.Item;
using KiotaBlazorBug.Client.User.Login;
using KiotaBlazorBug.Client.User.Logout;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaBlazorBug.Client.User
{
    /// <summary>
    /// Builds and executes requests for operations under \user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The createWithList property</summary>
        public global::KiotaBlazorBug.Client.User.CreateWithList.CreateWithListRequestBuilder CreateWithList
        {
            get => new global::KiotaBlazorBug.Client.User.CreateWithList.CreateWithListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The login property</summary>
        public global::KiotaBlazorBug.Client.User.Login.LoginRequestBuilder Login
        {
            get => new global::KiotaBlazorBug.Client.User.Login.LoginRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logout property</summary>
        public global::KiotaBlazorBug.Client.User.Logout.LogoutRequestBuilder Logout
        {
            get => new global::KiotaBlazorBug.Client.User.Logout.LogoutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the KiotaBlazorBug.Client.user.item collection</summary>
        /// <param name="position">The name that needs to be fetched. Use user1 for testing. </param>
        /// <returns>A <see cref="global::KiotaBlazorBug.Client.User.Item.WithUsernameItemRequestBuilder"/></returns>
        public global::KiotaBlazorBug.Client.User.Item.WithUsernameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("username", position);
                return new global::KiotaBlazorBug.Client.User.Item.WithUsernameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaBlazorBug.Client.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaBlazorBug.Client.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user", rawUrl)
        {
        }
        /// <summary>
        /// This can only be done by the logged in user.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaBlazorBug.Client.Models.User">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(global::KiotaBlazorBug.Client.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PostAsync(global::KiotaBlazorBug.Client.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::KiotaBlazorBug.Client.Models.User.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This can only be done by the logged in user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::KiotaBlazorBug.Client.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::KiotaBlazorBug.Client.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/xml");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::KiotaBlazorBug.Client.User.UserRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KiotaBlazorBug.Client.User.UserRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KiotaBlazorBug.Client.User.UserRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
