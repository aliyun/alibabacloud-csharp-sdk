// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA54FE21-B006-5DFF-8D64-C4FFECDA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The baselines.</para>
        /// </summary>
        [NameInMap("Risks")]
        [Validation(Required=false)]
        public List<DescribeRisksResponseBodyRisks> Risks { get; set; }
        public class DescribeRisksResponseBodyRisks : TeaModel {
            /// <summary>
            /// <para>The description of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ubuntu 14,Ubuntu 16 ,Ubuntu 18,Ubuntu 20 baseline based on Alibaba Cloud best security practices</para>
            /// </summary>
            [NameInMap("RiskDetail")]
            [Validation(Required=false)]
            public string RiskDetail { get; set; }

            /// <summary>
            /// <para>The baseline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54</para>
            /// </summary>
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            /// <summary>
            /// <para>The name of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Standard - Ubuntu Security Baseline</para>
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>The name of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cis</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>The name of the baseline subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc_ubuntu</para>
            /// </summary>
            [NameInMap("SubRiskType")]
            [Validation(Required=false)]
            public string SubRiskType { get; set; }

            /// <summary>
            /// <para>The display name of the baseline subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Standard - Ubuntu Security Baseline</para>
            /// </summary>
            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            /// <summary>
            /// <para>The display name of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Best security practices</para>
            /// </summary>
            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
