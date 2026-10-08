// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of major engine version upgrade tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionTasksResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The statistics information collection pattern.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>After</b>: Upgrade after the cutover.</description></item>
            /// <item><description><b>Before</b>: Upgrade before the cutover.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>After</para>
            /// </summary>
            [NameInMap("CollectStatMode")]
            [Validation(Required=false)]
            public string CollectStatMode { get; set; }

            /// <summary>
            /// <para>The detailed information about the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-27 15:03:05 --- do upgrade precheck on slave succcess.\n2021-10-27 15:03:11 --- begin to upgrade major version, source instance will locked in readonly mode.\n2021-10-27 15:03:21 --- upgrade master success.\n2021-10-27 15:06:10 --- exchange source and target instance dns success.\n</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The end time of the major engine version upgrade.</para>
            /// <para>The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614237779000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The final result of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: The task is successful.</description></item>
            /// <item><description><b>Failed</b>: The task failed.</description></item>
            /// <item><description><b>Running</b>: The migration is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The ID of the original instance before the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp1i3kkq7321****</para>
            /// </summary>
            [NameInMap("SourceInsName")]
            [Validation(Required=false)]
            public string SourceInsName { get; set; }

            /// <summary>
            /// <para>The version of the original instance before the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.0</para>
            /// </summary>
            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            /// <summary>
            /// <para>The start time of the major engine version upgrade.</para>
            /// <para>The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614236007000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The end time of the instance switchover from the original instance to the new instance.</para>
            /// <para>The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1714237539000</para>
            /// </summary>
            [NameInMap("SwitchEndTime")]
            [Validation(Required=false)]
            public string SwitchEndTime { get; set; }

            /// <summary>
            /// <para>The time of the instance switchover from the original instance to the new instance.</para>
            /// <para>The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614237539000</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The ID of the new instance after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp1c0v6d8092****</para>
            /// </summary>
            [NameInMap("TargetInsName")]
            [Validation(Required=false)]
            public string TargetInsName { get; set; }

            /// <summary>
            /// <para>The major engine version after the upgrade. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10.0</b></description></item>
            /// <item><description><b>11.0</b></description></item>
            /// <item><description><b>12.0</b></description></item>
            /// <item><description><b>13.0</b></description></item>
            /// <item><description><b>14.0</b></description></item>
            /// <item><description><b>15.0</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12.0</para>
            /// </summary>
            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>342900000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// <para>The upgrade mode.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>clone</b>: no cutover</description></item>
            /// <item><description><b>switch</b>: cutover</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>switch</para>
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

            /// <summary>
            /// <para>Indicates whether a cutover is performed.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A cutover is performed.</description></item>
            /// <item><description><b>false</b>: No cutover is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cutOver")]
            [Validation(Required=false)]
            public bool? CutOver { get; set; }

            /// <summary>
            /// <para>The estimated synchronization time for the logical replication lag. Unit: seconds.</para>
            /// <remarks>
            /// <para>This parameter is used only for <b>zero-downtime</b> major engine version upgrades.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalLogicRepDelayTime")]
            [Validation(Required=false)]
            public int? TotalLogicRepDelayTime { get; set; }

            /// <summary>
            /// <para>The size of the logical replication lag. Unit: MB.</para>
            /// <remarks>
            /// <para>This parameter is used only for <b>zero-downtime</b> major engine version upgrades.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalLogicRepLatencyMB")]
            [Validation(Required=false)]
            public int? TotalLogicRepLatencyMB { get; set; }

            /// <summary>
            /// <para>The temporary internal endpoint of the higher-version instance for the zero-downtime major engine version upgrade. The format is <c>****.pg.rds.aliyuncs.com</c>.</para>
            /// <remarks>
            /// <para>This parameter is used only for <b>zero-downtime</b> major engine version upgrades.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>****.pg.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("zeroDownTimeConnectionString")]
            [Validation(Required=false)]
            public string ZeroDownTimeConnectionString { get; set; }

            /// <summary>
            /// <para>The port of the higher-version instance, which is the same as the port of the source instance.</para>
            /// <remarks>
            /// <para>This parameter is used only for <b>zero-downtime</b> major engine version upgrades.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("zeroDownTimePort")]
            [Validation(Required=false)]
            public int? ZeroDownTimePort { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>152E0C6D-B9C3-4468-9F2C-FEF9D9E8417B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
