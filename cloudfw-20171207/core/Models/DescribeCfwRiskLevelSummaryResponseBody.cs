// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeCfwRiskLevelSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1F30435-FA0A-52DA-A5DE-C16FD6C171DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of threats.</para>
        /// </summary>
        [NameInMap("RiskList")]
        [Validation(Required=false)]
        public List<DescribeCfwRiskLevelSummaryResponseBodyRiskList> RiskList { get; set; }
        public class DescribeCfwRiskLevelSummaryResponseBodyRiskList : TeaModel {
            /// <summary>
            /// <para>The threat level. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>medium</b>: medium</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The number of ECS instances at risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Num")]
            [Validation(Required=false)]
            public string Num { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceNotProtected</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
