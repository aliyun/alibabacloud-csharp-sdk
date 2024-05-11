// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiRequest : TeaModel {
        /// <summary>
        /// The type of the two-way communication API. Valid values:
        /// 
        /// *   **COMMON**: general APIs
        /// *   **REGISTER**: registered APIs
        /// *   **UNREGISTER**: unregistered APIs
        /// *   **NOTIFY**: downstream notification
        /// </summary>
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        /// <summary>
        /// The ID of the API.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// The name of the API. The name must be unique within the API group. The name must be 4 to 50 characters in length. It must start with a letter and can contain letters, digits, and underscores (_).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The ID of the backend service.
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// The configuration items of API requests sent by the consumer to API Gateway.
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// Configuration Mode
        /// </summary>
        [NameInMap("BackendEnable")]
        [Validation(Required=false)]
        public bool? BackendEnable { get; set; }

        /// <summary>
        /// Specifies whether to enable backend services.
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public string ConstantParameters { get; set; }

        /// <summary>
        /// The description of the API. The description can be up to 180 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The AppCode authentication type supported. Valid values:
        /// 
        /// *   DEFAULT: supported after being made available in Alibaba Cloud Marketplace
        /// *   DISABLE: not supported
        /// *   HEADER : supported only in the Header parameter
        /// *   HEADER_QUERY: supported in the Header or Query parameter
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public string ErrorCodeSamples { get; set; }

        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// *   Specifies whether to set DisableInternet to **true** to limit API calls to within the VPC.
        /// *   If you set DisableInternet to **false**, the limit if lifted.
        /// 
        /// >  If you do not set this parameter, the original value is used.
        /// </summary>
        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        /// <summary>
        /// The ID of the API group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The client-side request signature method of the API. Valid values:
        /// 
        /// *   HmacSHA256
        /// *   HmacSHA1,HmacSHA256
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public string OpenIdConnectConfig { get; set; }

        /// <summary>
        /// The configuration items of API requests sent by API Gateway to the backend service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public string RequestConfig { get; set; }

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public string RequestParameters { get; set; }

        /// <summary>
        /// *   Specifies whether to set **ForceNonceCheck** to **true** to force the check of X-Ca-Nonce during the request. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.
        /// *   If you set **ForceNonceCheck** to **false**, the check is not performed. If you do not set this parameter, the original value is used.
        /// </summary>
        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public string ResultDescriptions { get; set; }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// The sample response from the backend service.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The parameters of API requests sent by the consumer to API Gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public string ServiceParametersMap { get; set; }

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public string SystemParameters { get; set; }

        /// <summary>
        /// Specifies whether the API is public. Valid values:
        /// 
        /// *   **PUBLIC**: Make the API public. If you set this parameter to PUBLIC, this API is displayed on the APIs page for all users after the API is published to the production environment.
        /// *   **PRIVATE**: Make the API private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// The returned description of the API.
        /// </summary>
        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
