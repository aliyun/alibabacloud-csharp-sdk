// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetFlowResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFlowResponseBodyData Data { get; set; }
        public class GetFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of categories.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The API version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.0</para>
            /// </summary>
            [NameInMap("DataApiVersion")]
            [Validation(Required=false)]
            public string DataApiVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://abc.com">http://abc.com</a></para>
            /// </summary>
            [NameInMap("EndpointUri")]
            [Validation(Required=false)]
            public string EndpointUri { get; set; }

            /// <summary>
            /// <para>The flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92675332812643****</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The flow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flow_001</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <para>The JSON version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.1</para>
            /// </summary>
            [NameInMap("JSONVersion")]
            [Validation(Required=false)]
            public string JSONVersion { get; set; }

            /// <summary>
            /// <para>The temporary preview URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://pre-url">https://pre-url</a></para>
            /// </summary>
            [NameInMap("PreviewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }

            /// <summary>
            /// <para>The expiration time of the preview URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700617436633</para>
            /// </summary>
            [NameInMap("PreviewUrlExpires")]
            [Validation(Required=false)]
            public long? PreviewUrlExpires { get; set; }

            /// <summary>
            /// <para>The status of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAC72B08-3327-33EF-BEDC-8EC3E83A6575</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
