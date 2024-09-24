// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulFixStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the statistics of vulnerability fixes by vulnerability type.</para>
        /// </summary>
        [NameInMap("FixStat")]
        [Validation(Required=false)]
        public List<DescribeVulFixStatisticsResponseBodyFixStat> FixStat { get; set; }
        public class DescribeVulFixStatisticsResponseBodyFixStat : TeaModel {
            /// <summary>
            /// <para>The number of vulnerabilities that are fixed on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FixedTodayNum")]
            [Validation(Required=false)]
            public int? FixedTodayNum { get; set; }

            /// <summary>
            /// <para>The total number of fixed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("FixedTotalNum")]
            [Validation(Required=false)]
            public int? FixedTotalNum { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities that are being fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("FixingNum")]
            [Validation(Required=false)]
            public int? FixingNum { get; set; }

            /// <summary>
            /// <para>The number of unfixed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("NeedFixNum")]
            [Validation(Required=false)]
            public int? NeedFixNum { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
            /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
            /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
            /// <item><description><b>app</b>: application vulnerability</description></item>
            /// <item><description><b>emg</b>: urgent vulnerability</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total statistics of vulnerability fixes.</para>
        /// </summary>
        [NameInMap("FixTotal")]
        [Validation(Required=false)]
        public DescribeVulFixStatisticsResponseBodyFixTotal FixTotal { get; set; }
        public class DescribeVulFixStatisticsResponseBodyFixTotal : TeaModel {
            /// <summary>
            /// <para>The number of vulnerabilities that are fixed on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("FixedTodayNum")]
            [Validation(Required=false)]
            public int? FixedTodayNum { get; set; }

            /// <summary>
            /// <para>The total number of fixed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("FixedTotalNum")]
            [Validation(Required=false)]
            public int? FixedTotalNum { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities that are being fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("FixingNum")]
            [Validation(Required=false)]
            public int? FixingNum { get; set; }

            /// <summary>
            /// <para>The number of unfixed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62</para>
            /// </summary>
            [NameInMap("NeedFixNum")]
            [Validation(Required=false)]
            public int? NeedFixNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F3B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
