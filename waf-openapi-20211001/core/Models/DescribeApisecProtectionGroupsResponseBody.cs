// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecProtectionGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The protected object groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecProtectionGroupsResponseBodyData> Data { get; set; }
        public class DescribeApisecProtectionGroupsResponseBodyData : TeaModel {
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public long? ReportStatus { get; set; }

            /// <summary>
            /// <para>The name of the protected object group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

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
        /// <para>D7861F61-5B61-46CE-A47C-6B19****5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of protected object groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
