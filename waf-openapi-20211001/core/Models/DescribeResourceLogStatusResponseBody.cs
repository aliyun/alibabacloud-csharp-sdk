// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DABF8AB-2321-5F8D-A8D7-922D757FBFFE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeResourceLogStatusResponseBodyResult> Result { get; set; }
        public class DescribeResourceLogStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The queried protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-wewbb23dfsetetcic****</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The log enabling status of the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Logging is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Logging is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>The Tracing Analysis configuration.</para>
            /// </summary>
            [NameInMap("TraceConfig")]
            [Validation(Required=false)]
            public DescribeResourceLogStatusResponseBodyResultTraceConfig TraceConfig { get; set; }
            public class DescribeResourceLogStatusResponseBodyResultTraceConfig : TeaModel {
                /// <summary>
                /// <para>The per-mille sampling ratio for Tracing Analysis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("RatePerMille")]
                [Validation(Required=false)]
                public int? RatePerMille { get; set; }

                /// <summary>
                /// <para>The Hybrid Cloud Monitoring 2.0 workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cms-test</para>
                /// </summary>
                [NameInMap("Workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The Tracing Analysis status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Tracing Analysis is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Tracing Analysis is shutdown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TraceStatus")]
            [Validation(Required=false)]
            public bool? TraceStatus { get; set; }

        }

    }

}
