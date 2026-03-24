// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventTopMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12EF3845-CCEB-4B84-AE60-2B49B*****EE5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of statistics.</para>
        /// </summary>
        [NameInMap("TopMetrics")]
        [Validation(Required=false)]
        public List<DescribeThreatEventTopMetricResponseBodyTopMetrics> TopMetrics { get; set; }
        public class DescribeThreatEventTopMetricResponseBodyTopMetrics : TeaModel {
            /// <summary>
            /// <para>The number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Cnt")]
            [Validation(Required=false)]
            public long? Cnt { get; set; }

            /// <summary>
            /// <para>The country where the source IP address of the attack is located.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Metric</b> is set to <b>src</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The region where the source IP address of the attack is located.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Metric</b> is set to <b>src</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The attack value. The meaning of this parameter varies based on the value of <b>Metric</b>.</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>Metric</b> is set to <b>time</b>, this parameter indicates the attack time.</para>
            /// </description></item>
            /// <item><description><para>If <b>Metric</b> is set to <b>src</b>, this parameter indicates the source IP address of the attack.</para>
            /// </description></item>
            /// <item><description><para>If <b>Metric</b> is set to <b>target</b>, this parameter indicates the URL of the attack request.</para>
            /// </description></item>
            /// <item><description><para>If <b>Metric</b> is set to <b>type</b>, this parameter indicates the attack type. For example, <b>dirscan</b> indicates directory scan and <b>webscan</b> indicates web scan. For more information about other attack types, see the description of the <b>detectType</b> parameter for custom regular expression rules (<b>regular_custom</b>) in the <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a> operation.</para>
            /// </description></item>
            /// <item><description><para>If <b>Metric</b> is set to <b>tools</b>, this parameter indicates the attack tool.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>115.28.209.212</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
