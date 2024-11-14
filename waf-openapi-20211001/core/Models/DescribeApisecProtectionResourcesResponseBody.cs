// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecProtectionResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The protected objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecProtectionResourcesResponseBodyData> Data { get; set; }
        public class DescribeApisecProtectionResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The switch of the API security module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApisecStatus")]
            [Validation(Required=false)]
            public long? ApisecStatus { get; set; }

            /// <summary>
            /// <para>The switch of the compliance check feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public long? ReportStatus { get; set; }

            /// <summary>
            /// <para>The protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cwaf-***-waf</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The switch of the tracing and auditing feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TraceStatus")]
            [Validation(Required=false)]
            public long? TraceStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EFCFE18-78F8-5079-B312-07***48B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
