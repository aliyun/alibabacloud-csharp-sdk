// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateApiRequest : TeaModel {
        /// <summary>
        /// The type of the two-way communication API.
        /// 
        /// *   **COMMON**: normal APIs
        /// *   **REGISTER**: registered APIs
        /// *   **UNREGISTER**: unregistered APIs
        /// *   **NOTIFY**: downstream notification APIs
        /// </summary>
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        /// <summary>
        /// The name of the API that you want to create. The name must be unique within the API group. The name must be 4 to 50 characters in length. It must start with a letter and can contain letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The IDof the backend service
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// The configuration items of API requests sent by the consumer to API Gateway.
        /// 
        /// For more information, see [RequestConfig](~~43985~~).
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// Specifies whether to enable backend services.
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
        /// If **AuthType** is set to **APP**, the valid values are:
        /// 
        /// *   **DEFAULT**: The default value that is used if no other values are passed. This value means that the setting of the group is used.
        /// *   **DISABLE**: The authentication is disabled.
        /// *   **HEADER**: AppCode can be placed in the Header parameter for authentication.
        /// *   **HEADER_QUERY**: AppCode can be placed in the Header or Query parameter for authentication.
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
        /// *   Specifies whether to set **DisableInternet** to **true** to limit API calls to within the VPC.
        /// *   If you set **DisableInternet** to **false**, the limit is lifted. The default value is false when you create an API.
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
        /// If the **AuthType** is **APP** authentication, you need to pass this value to specify the signature algorithm. If you do not specify this parameter, the default value HmacSHA256 is used. Valid values:
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
        /// For more information, see [ServiceConfig](~~43987~~).
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public string RequestConfig { get; set; }

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public string RequestParameters { get; set; }

        /// <summary>
        /// *   Specifies whether to set **ForceNonceCheck** to **true** to force the check of X-Ca-Nonce during the request. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.
        /// *   If you set **ForceNonceCheck** to **false**, the check is not performed. The default value is false when you create an API.
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
        /// For more information, see [RequestParameter](~~43986~~).
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
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateApiRequestTag> Tag { get; set; }
        public class CreateApiRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to make the API public. Valid values:
        /// 
        /// *   **PUBLIC**: Make the API public. If you set this parameter to PUBLIC, this API is displayed on the APIs page for all users after the API is published to the production environment.
        /// *   **PRIVATE**: Make the API private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// The return description of the API.
        /// </summary>
        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
