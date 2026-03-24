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
            /// <para>The number of APIs involved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ApiCount")]
            [Validation(Required=false)]
            public long? ApiCount { get; set; }

            /// <summary>
            /// <para>The number of sites involved.</para>
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
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported types of sensitive data.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SensitiveCode")]
            [Validation(Required=false)]
            public string SensitiveCode { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>S1</b>: Low sensitivity.</para>
            /// </description></item>
            /// <item><description><para><b>S2</b>: Medium sensitivity.</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: High sensitivity.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S3</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The data name of the sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>自定义敏感类型。</para>
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
