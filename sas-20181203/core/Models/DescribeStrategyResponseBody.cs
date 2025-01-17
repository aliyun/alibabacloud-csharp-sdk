// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75C127E6-76CD-59A7-B6E4-1CBBDC98F2EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the baseline check policies.</para>
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public List<DescribeStrategyResponseBodyStrategies> Strategies { get; set; }
        public class DescribeStrategyResponseBodyStrategies : TeaModel {
            /// <summary>
            /// <para>The details of the assets to which the baseline check policy is applied.</para>
            /// </summary>
            [NameInMap("ConfigTargets")]
            [Validation(Required=false)]
            public List<DescribeStrategyResponseBodyStrategiesConfigTargets> ConfigTargets { get; set; }
            public class DescribeStrategyResponseBodyStrategiesConfigTargets : TeaModel {
                /// <summary>
                /// <para>Indicates whether the baseline check policy is applied to the asset group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>add</b>: The baseline check policy is applied to the asset group.</description></item>
                /// <item><description><b>del</b>: the baseline check policy is not applied to the asset group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                /// <summary>
                /// <para>The asset group ID or UUID of the asset to which the baseline check policy is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10099713</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The condition by which the baseline check policy is applied to the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>groupId</b>: the ID of the asset group</description></item>
                /// <item><description><b>uuid</b>: the UUID of the asset</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>groupId</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The type of the baseline check policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>common</b></description></item>
            /// <item><description><b>custom</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public string CustomType { get; set; }

            /// <summary>
            /// <para>The cycle of the baseline check. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: every 2 days</description></item>
            /// <item><description><b>3</b>: every 4 days</description></item>
            /// <item><description><b>7</b>: every 8 days</description></item>
            /// <item><description>30: every 31 days</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CycleDays")]
            [Validation(Required=false)]
            public int? CycleDays { get; set; }

            /// <summary>
            /// <para>The time when the baseline check starts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The baseline check starts within the time range from 00:00 to 06:00.</description></item>
            /// <item><description><b>6</b>: The baseline check starts within the time range from 06:00 to 12:00.</description></item>
            /// <item><description><b>12</b>: The baseline check starts within the time range from 12:00 to 18:00.</description></item>
            /// <item><description><b>18</b>: The baseline check starts within the time range from 18:00 to 24:00.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CycleStartTime")]
            [Validation(Required=false)]
            public int? CycleStartTime { get; set; }

            /// <summary>
            /// <para>The number of the assets to which the baseline check policy is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("EcsCount")]
            [Validation(Required=false)]
            public int? EcsCount { get; set; }

            /// <summary>
            /// <para>The end time of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The status of the baseline check policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: not executed</description></item>
            /// <item><description><b>2</b>: executing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecStatus")]
            [Validation(Required=false)]
            public int? ExecStatus { get; set; }

            /// <summary>
            /// <para>The ID of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8164248</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The name of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text2</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The proportion of risky baselines in the baseline check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PassRate")]
            [Validation(Required=false)]
            public int? PassRate { get; set; }

            /// <summary>
            /// <para>The progress of the baseline check by using the baseline. This parameter is returned only if the value of the ExecStatus parameter is 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of the assets on which the baseline check is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ProcessRate")]
            [Validation(Required=false)]
            public int? ProcessRate { get; set; }

            /// <summary>
            /// <para>The number of baseline check items in the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }

            /// <summary>
            /// <para>The start time of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The source type of the baseline check policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: indicates a built-in policy provided and performed by Security Center by default.</description></item>
            /// <item><description><b>2</b>: indicates a user-defined policy. It can be a standard or custom baseline check policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The time when the baseline check policy was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-07 10:46:43</para>
            /// </summary>
            [NameInMap("UserModifyTime")]
            [Validation(Required=false)]
            public long? UserModifyTime { get; set; }

        }

    }

}
