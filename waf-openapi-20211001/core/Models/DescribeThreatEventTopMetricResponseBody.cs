// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventTopMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
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
            /// <para>The country to which the source IP address of the attack belongs.</para>
            /// <remarks>
            /// <para>This field returns a meaningful value only when the statistical object (<b>Metric</b>) is set to source IP address (<b>src</b>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The region to which the source IP address of the attack belongs.</para>
            /// <remarks>
            /// <para>This field returns a meaningful value only when the statistical object (<b>Metric</b>) is set to source IP address (<b>src</b>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The attack value. The meaning of this field varies depending on the value of <b>Metric</b>.</para>
            /// <list type="bullet">
            /// <item><description>If <b>Metric</b> is set to <b>time</b>, this field indicates the attack time.</description></item>
            /// <item><description>If <b>Metric</b> is set to <b>src</b>, this field indicates the source IP address of the attack.</description></item>
            /// <item><description>If <b>Metric</b> is set to <b>target</b>, this field indicates the URL of the attack request.</description></item>
            /// <item><description>If <b>Metric</b> is set to <b>type</b>, this field indicates the attack type. <b>dirscan</b> indicates directory scanning, <b>webscan</b> indicates web scanning, and other attack types are described in the <b>detectType</b> (detection type) parameter of the <b>custom regular rule</b> (<b>regular_custom</b>) in the <a href="https://help.aliyun.com/document_detail/461421.html"><b>CreateDefenseRule</b></a> operation.</description></item>
            /// <item><description>If <b>Metric</b> is set to <b>tools</b>, this field indicates the attack tool.</description></item>
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
