// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiDocResponseBody : TeaModel {
        /// <summary>
        /// The ID of the API.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// The name of the API
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The security authentication method. Valid values: APP, ANONYMOUS, and APPOPENID, indicating respectively Alibaba Cloud application authentication, anonymous authentication, and third-party OpenID Connect account authentication.
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The publishing time.
        /// </summary>
        [NameInMap("DeployedTime")]
        [Validation(Required=false)]
        public string DeployedTime { get; set; }

        /// <summary>
        /// The API description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// *   Specifies whether to set **DisableInternet** to **true** to limit API calls to within the VPC.
        /// *   If you set **DisableInternet** to **false**, the limit is lifted. The default value is false when you create an API.
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        /// <summary>
        /// The sample error codes returned by the backend service.
        /// </summary>
        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiDocResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiDocResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                /// <summary>
                /// The returned error code.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The error description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The returned error message.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// The sample error response from the backend service.
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// *   Specifies whether to set **ForceNonceCheck** to **true** to force the check of X-Ca-Nonce during the request. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.
        /// *   If you set **ForceNonceCheck** to **false**, the check is not performed. The default value is false when you create an API.
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
        /// The name of the API group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The region ID of the API group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The returned API frontend definition. It is an array consisting of RequestConfig data.
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiDocResponseBodyRequestConfig : TeaModel {
            /// <summary>
            /// This parameter takes effect only when the RequestMode parameter is set to MAPPING.********
            /// 
            /// The server data transmission method used for POST and PUT requests. Valid values: FORM and STREAM. FORM indicates that data in key-value pairs is transmitted as forms. STREAM indicates that data is transmitted as byte streams.
            /// </summary>
            [NameInMap("BodyFormat")]
            [Validation(Required=false)]
            public string BodyFormat { get; set; }

            [NameInMap("EscapePathParam")]
            [Validation(Required=false)]
            public bool? EscapePathParam { get; set; }

            /// <summary>
            /// The description of the request body.
            /// </summary>
            [NameInMap("PostBodyDescription")]
            [Validation(Required=false)]
            public string PostBodyDescription { get; set; }

            /// <summary>
            /// The HTTP method used to make the request. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.
            /// </summary>
            [NameInMap("RequestHttpMethod")]
            [Validation(Required=false)]
            public string RequestHttpMethod { get; set; }

            /// <summary>
            /// The request mode. Valid values:
            /// 
            /// *   MAPPING: Parameters are mapped. Unknown parameters are filtered out.
            /// *   PASSTHROUGH: Parameters are passed through.
            /// *   MAPPING_PASSTHROUGH: Parameters are mapped. Unknown parameters are passed through.
            /// </summary>
            [NameInMap("RequestMode")]
            [Validation(Required=false)]
            public string RequestMode { get; set; }

            /// <summary>
            /// The API request path. If the complete API URL is `http://api.a.com:8080/object/add?key1=value1&key2=value2`, the API request path is ` /object/add  `.
            /// </summary>
            [NameInMap("RequestPath")]
            [Validation(Required=false)]
            public string RequestPath { get; set; }

            /// <summary>
            /// The protocol type supported by the API. Valid values: HTTP and HTTPS. Separate multiple values with commas (,), such as "HTTP,HTTPS".
            /// </summary>
            [NameInMap("RequestProtocol")]
            [Validation(Required=false)]
            public string RequestProtocol { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned frontend input parameters in the API. It is an array consisting of RequestParameter data.
        /// </summary>
        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeApiDocResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeApiDocResponseBodyRequestParametersRequestParameter : TeaModel {
                /// <summary>
                /// The name of the parameter in the API request.
                /// </summary>
                [NameInMap("ApiParameterName")]
                [Validation(Required=false)]
                public string ApiParameterName { get; set; }

                /// <summary>
                /// The type of the array element.
                /// </summary>
                [NameInMap("ArrayItemsType")]
                [Validation(Required=false)]
                public string ArrayItemsType { get; set; }

                /// <summary>
                /// The default value.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// The example value.
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The parameter description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The order in which the parameter is sorted in the document.
                /// </summary>
                [NameInMap("DocOrder")]
                [Validation(Required=false)]
                public int? DocOrder { get; set; }

                /// <summary>
                /// Indicates whether the document is public. Valid values: **PUBLIC** and **PRIVATE**.
                /// </summary>
                [NameInMap("DocShow")]
                [Validation(Required=false)]
                public string DocShow { get; set; }

                /// <summary>
                /// The hash values that are supported when **ParameterType** is set to Int, Long, Float, Double, or String. Separate values with commas (,). Examples: 1,2,3,4,9 and A,B,C,E,F.
                /// </summary>
                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                /// <summary>
                /// JSON scheme
                /// </summary>
                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

                /// <summary>
                /// The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The maximum length.
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// The maximum value.
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public long? MaxValue { get; set; }

                /// <summary>
                /// The minimum length.
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                /// <summary>
                /// The minimum value.
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public long? MinValue { get; set; }

                /// <summary>
                /// The data type of the parameter.
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// The regular expression that is used for parameter validation when **ParameterType** is set to String.
                /// </summary>
                [NameInMap("RegularExpression")]
                [Validation(Required=false)]
                public string RegularExpression { get; set; }

                /// <summary>
                /// Indicates whether the parameter is required.
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public string Required { get; set; }

            }

        }

        /// <summary>
        /// The sample response.
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// The return value type.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// The name of the runtime environment. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **TEST**
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// Indicates whether the API is public. Valid values: PUBLIC and PRIVATE.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
