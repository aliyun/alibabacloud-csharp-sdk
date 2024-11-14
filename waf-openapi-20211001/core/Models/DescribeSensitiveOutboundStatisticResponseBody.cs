// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveOutboundStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The data types of personal information involved in cross-border data transfer.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveOutboundStatisticResponseBodyData> Data { get; set; }
        public class DescribeSensitiveOutboundStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The evaluation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>report</b>: Risks exist in cross-border data transfer.</description></item>
            /// <item><description><b>none</b>: No risks exist in cross-border data transfer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>report</para>
            /// </summary>
            [NameInMap("DetectionResult")]
            [Validation(Required=false)]
            public string DetectionResult { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>546</para>
            /// </summary>
            [NameInMap("InfoCount")]
            [Validation(Required=false)]
            public long? InfoCount { get; set; }

            /// <summary>
            /// <para>The number of data entries that are transferred across borders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("OutboundCount")]
            [Validation(Required=false)]
            public long? OutboundCount { get; set; }

            /// <summary>
            /// <para>The type of the sensitive data.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeApisecRules~~">DescribeApisecRules</a> operation to query the supported types of sensitive data.</para>
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
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The type of the information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>info</b>: full personal information</description></item>
            /// <item><description><b>sensitive</b>: sensitive personal information</description></item>
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
