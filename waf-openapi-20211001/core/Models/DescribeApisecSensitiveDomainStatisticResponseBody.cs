// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecSensitiveDomainStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecSensitiveDomainStatisticResponseBodyData> Data { get; set; }
        public class DescribeApisecSensitiveDomainStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of APIs that are involved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ApiCount")]
            [Validation(Required=false)]
            public long? ApiCount { get; set; }

            /// <summary>
            /// <para>The number of sites that are involved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            /// <summary>
            /// <para>The code of the sensitive data.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported sensitive data types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SensitiveCode")]
            [Validation(Required=false)]
            public string SensitiveCode { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the sensitive data.Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>S1</b>: low sensitivity.</description></item>
            /// <item><description><b>S2</b>: moderate sensitivity.</description></item>
            /// <item><description><b>S3</b>: high sensitivity.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>L3</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("SensitiveName")]
            [Validation(Required=false)]
            public string SensitiveName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56B40D30-4960-4F19-B7D5-2B1F***6CB70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
