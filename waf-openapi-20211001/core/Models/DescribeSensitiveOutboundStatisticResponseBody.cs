// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveOutboundStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of statistics on outbound transfers of personal information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveOutboundStatisticResponseBodyData> Data { get; set; }
        public class DescribeSensitiveOutboundStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The assessment result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>report</b>: a data outbound transfer threat exists.</para>
            /// </description></item>
            /// <item><description><para><b>none</b>: no data outbound transfer threat exists.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>report</para>
            /// </summary>
            [NameInMap("DetectionResult")]
            [Validation(Required=false)]
            public string DetectionResult { get; set; }

            /// <summary>
            /// <para>The total number of personal information data entries detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>546</para>
            /// </summary>
            [NameInMap("InfoCount")]
            [Validation(Required=false)]
            public long? InfoCount { get; set; }

            /// <summary>
            /// <para>The number of outbound transfer data entries for the sensitive data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("OutboundCount")]
            [Validation(Required=false)]
            public long? OutboundCount { get; set; }

            /// <summary>
            /// <para>The code that represents the type of sensitive data.</para>
            /// <remarks>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to obtain the supported sensitive data types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("SensitiveCode")]
            [Validation(Required=false)]
            public long? SensitiveCode { get; set; }

            /// <summary>
            /// <para>The sensitivity level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>high</b>: high.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: medium.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: low.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The type of information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>info</b>: all personal information.</para>
            /// </description></item>
            /// <item><description><para><b>sensitive</b>: only sensitive personal information.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>info</para>
            /// </summary>
            [NameInMap("SensitiveType")]
            [Validation(Required=false)]
            public string SensitiveType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EFCFE18-78F8-5079-B312-07***48B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned for outbound transfer statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
