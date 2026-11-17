// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineEvidenceRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>The AI interpretation result in the specified language, in Markdown format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This request has SQL injection risk.</para>
        /// </summary>
        [NameInMap("AiInterpretation")]
        [Validation(Required=false)]
        public string AiInterpretation { get; set; }

        /// <summary>
        /// <para>The list of attack source groups for the request.</para>
        /// </summary>
        [NameInMap("AttackSources")]
        [Validation(Required=false)]
        public List<DescribeAiEngineEvidenceRequestResponseBodyAttackSources> AttackSources { get; set; }
        public class DescribeAiEngineEvidenceRequestResponseBodyAttackSources : TeaModel {
            /// <summary>
            /// <para>The list of sources of this type.</para>
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public List<DescribeAiEngineEvidenceRequestResponseBodyAttackSourcesSources> Sources { get; set; }
            public class DescribeAiEngineEvidenceRequestResponseBodyAttackSourcesSources : TeaModel {
                /// <summary>
                /// <para>The display attribute of the source, such as the region code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>US-CA</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The source value, such as an IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the attack source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The evidence ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EVD-20241025-001</para>
        /// </summary>
        [NameInMap("EvidenceId")]
        [Validation(Required=false)]
        public string EvidenceId { get; set; }

        /// <summary>
        /// <para>The host of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.example.com</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The HTTP response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("HttpStatus")]
        [Validation(Required=false)]
        public int? HttpStatus { get; set; }

        /// <summary>
        /// <para>The evidence impact tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>block</b>: The request is blocked.</para>
        /// </description></item>
        /// <item><description><para><b>challenge</b>: The request triggers a challenge.</para>
        /// </description></item>
        /// <item><description><para><b>monitor</b>: The request is monitored.</para>
        /// </description></item>
        /// <item><description><para><b>bypass</b>: The request is suspected to be a bypass.</para>
        /// </description></item>
        /// <item><description><para><b>attempt</b>: The request is a reconnaissance probe.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bypass</para>
        /// </summary>
        [NameInMap("ImpactType")]
        [Validation(Required=false)]
        public string ImpactType { get; set; }

        /// <summary>
        /// <para>The HTTP method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The ID of the associated node, which corresponds to the NodeId in the node list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node-109-04</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The request content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET /api/orders/query?id=1%27 HTTP/1.1</para>
        /// </summary>
        [NameInMap("Request")]
        [Validation(Required=false)]
        public string Request { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A<em><b>2-1219-019A-8B44-255</b></em>**2C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The de-identified request path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/orders/query</para>
        /// </summary>
        [NameInMap("RequestPath")]
        [Validation(Required=false)]
        public string RequestPath { get; set; }

        /// <summary>
        /// <para>The time when the original request was made. The time is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1792973400000</para>
        /// </summary>
        [NameInMap("RequestTime")]
        [Validation(Required=false)]
        public long? RequestTime { get; set; }

        /// <summary>
        /// <para>The ID of the protected object to which the request belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com-waf">www.example.com-waf</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The response content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP/1.1 500 Internal Server Error</para>
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public string Response { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is a suspected bypass. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The request is a suspected bypass.</description></item>
        /// <item><description><b>0</b>: The request is not a bypass.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SuspectedBypass")]
        [Validation(Required=false)]
        public int? SuspectedBypass { get; set; }

        /// <summary>
        /// <para>The trace ID of the original request. The ID can be up to 128 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace-20241025-109-04</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
