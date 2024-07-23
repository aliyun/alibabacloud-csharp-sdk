// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The tasks for major engine version upgrades.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionTasksResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the system collects the statistics.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>After</b>: The system collects the statistics after a switchover.</description></item>
            /// <item><description><b>Before</b>: The system collects the statistics before a switchover.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>After</para>
            /// </summary>
            [NameInMap("CollectStatMode")]
            [Validation(Required=false)]
            public string CollectStatMode { get; set; }

            /// <summary>
            /// <para>The details of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-27 15:03:05 --- do upgrade precheck on slave succcess.\n2021-10-27 15:03:11 --- begin to upgrade major version, source instance will locked in readonly mode.\n2021-10-27 15:03:21 --- upgrade master success.\n2021-10-27 15:06:10 --- exchange source and target instance dns success.\n</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The end time of the task.</para>
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614237779000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The status of the task.</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: The task is successful.</description></item>
            /// <item><description><b>Failed</b>: The task failed.</description></item>
            /// <item><description><b>Running</b>: The task is in the phase in which data is being migrated to a new instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The ID of the original instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp1i3kkq7321****</para>
            /// </summary>
            [NameInMap("SourceInsName")]
            [Validation(Required=false)]
            public string SourceInsName { get; set; }

            /// <summary>
            /// <para>The major engine version of the original instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.0</para>
            /// </summary>
            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            /// <summary>
            /// <para>The start time of the task.</para>
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614236007000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The time at which your workloads are switched over from the original instance to the new instance.</para>
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614237539000</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The ID of the new instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp1c0v6d8092****</para>
            /// </summary>
            [NameInMap("TargetInsName")]
            [Validation(Required=false)]
            public string TargetInsName { get; set; }

            /// <summary>
            /// <para>The major engine version of the new instance. Valid values:</para>
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
            /// <item><description><b>clone</b>: The system does not migrate data to the new instance and does not switch your workloads over to the new instance.</description></item>
            /// <item><description><b>switch</b>: The system migrates data to the new instance and switches your workloads over to the new instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>switch</para>
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
