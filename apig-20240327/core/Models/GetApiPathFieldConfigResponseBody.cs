// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetApiPathFieldConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetApiPathFieldConfigResponseBodyData Data { get; set; }
        public class GetApiPathFieldConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the HTTP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-123456</para>
            /// </summary>
            [NameInMap("apiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The ID of the cloud-native API gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-123456</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The list of field configurations grouped by API request path.</para>
            /// </summary>
            [NameInMap("pathConfigs")]
            [Validation(Required=false)]
            public List<GetApiPathFieldConfigResponseBodyDataPathConfigs> PathConfigs { get; set; }
            public class GetApiPathFieldConfigResponseBodyDataPathConfigs : TeaModel {
                /// <summary>
                /// <para>The collection of field configurations under the path, grouped by mapping key, where each group represents a set of field configuration items.</para>
                /// </summary>
                [NameInMap("fieldPaths")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataPathConfigsFieldPathsValue>> FieldPaths { get; set; }

                /// <summary>
                /// <para>The request path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/v1/chat/completions</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
