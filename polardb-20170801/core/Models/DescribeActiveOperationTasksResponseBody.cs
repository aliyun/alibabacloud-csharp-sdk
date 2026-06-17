// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of O\&amp;M tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTasksResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether cancellation is allowed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: indicates that users are allowed to cancel the task.</para>
            /// </description></item>
            /// <item><description><para>0: indicates that cancellation is not allowed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AllowCancel")]
            [Validation(Required=false)]
            public long? AllowCancel { get; set; }

            /// <summary>
            /// <para>Indicates whether time modification is allowed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: indicates that users are allowed to modify the time.</para>
            /// </description></item>
            /// <item><description><para>0: indicates that users are not allowed to modify the time.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AllowChange")]
            [Validation(Required=false)]
            public long? AllowChange { get; set; }

            /// <summary>
            /// <para>The event level code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>S1: system maintenance.</para>
            /// </description></item>
            /// <item><description><para>S0: threat fix.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S0</para>
            /// </summary>
            [NameInMap("ChangeLevel")]
            [Validation(Required=false)]
            public string ChangeLevel { get; set; }

            /// <summary>
            /// <para>The event level (English).</para>
            /// 
            /// <b>Example:</b>
            /// <para>System maintenance</para>
            /// </summary>
            [NameInMap("ChangeLevelEn")]
            [Validation(Required=false)]
            public string ChangeLevelEn { get; set; }

            /// <summary>
            /// <para>The event level (Chinese).</para>
            /// 
            /// <b>Example:</b>
            /// <para>系统运维</para>
            /// </summary>
            [NameInMap("ChangeLevelZh")]
            [Validation(Required=false)]
            public string ChangeLevelZh { get; set; }

            /// <summary>
            /// <para>The creation time. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:42Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The current zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("CurrentAVZ")]
            [Validation(Required=false)]
            public string CurrentAVZ { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The list of node IDs.</para>
            /// </summary>
            [NameInMap("DBNodeIds")]
            [Validation(Required=false)]
            public List<string> DBNodeIds { get; set; }

            /// <summary>
            /// <para>The database engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MySQL</b></para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The kernel version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>The latest deadline for the adjustable range of task execution time. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-11T15:59:59Z</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The event impact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TransientDisconnection</para>
            /// </summary>
            [NameInMap("Impact")]
            [Validation(Required=false)]
            public string Impact { get; set; }

            /// <summary>
            /// <para>The event impact (English).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Transient instance disconnection</para>
            /// </summary>
            [NameInMap("ImpactEn")]
            [Validation(Required=false)]
            public string ImpactEn { get; set; }

            /// <summary>
            /// <para>The event impact (Chinese).</para>
            /// 
            /// <b>Example:</b>
            /// <para>集群闪断</para>
            /// </summary>
            [NameInMap("ImpactZh")]
            [Validation(Required=false)]
            public string ImpactZh { get; set; }

            /// <summary>
            /// <para>The cluster alias or cluster comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InsComment")]
            [Validation(Required=false)]
            public string InsComment { get; set; }

            /// <summary>
            /// <para>The modification time. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:42Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The preparation time required between the start time and the switch time. Format: HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04:00:00</para>
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            /// <summary>
            /// <para>The region code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The execution result information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userCancel</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The time when the background task is executed. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-19T02:48:17Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: indicates waiting for notification.</para>
            /// </description></item>
            /// <item><description><para>1: indicates retry notification.</para>
            /// </description></item>
            /// <item><description><para>2: indicates waiting for user-specified time.</para>
            /// </description></item>
            /// <item><description><para>3: indicates waiting for processing.</para>
            /// </description></item>
            /// <item><description><para>4: indicates in progress.</para>
            /// </description></item>
            /// <item><description><para>5: indicates successfully completed.</para>
            /// </description></item>
            /// <item><description><para>6: indicates failed.</para>
            /// </description></item>
            /// <item><description><para>7: indicates canceled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when the background initiates the switch operation. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>107202351</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// <para>The task parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;Action&quot;: &quot;UpgradeDBInstance&quot;
            /// }</para>
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// <para>The type of the pending event task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>DatabaseSoftwareUpgrading</b>: database software upgrade.</para>
            /// </description></item>
            /// <item><description><para><b>DatabaseHardwareMaintenance</b>: hardware maintenance and upgrade.</para>
            /// </description></item>
            /// <item><description><para><b>DatabaseStorageUpgrading</b>: database storage upgrade.</para>
            /// </description></item>
            /// <item><description><para><b>DatabaseProxyUpgrading</b>: proxy minor version upgrade.</para>
            /// </description></item>
            /// <item><description><para><b>all</b>: returns all types of pending events.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DatabaseSoftwareUpgrading</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The task reason in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Minor version update</para>
            /// </summary>
            [NameInMap("TaskTypeEn")]
            [Validation(Required=false)]
            public string TaskTypeEn { get; set; }

            /// <summary>
            /// <para>The task reason in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小版本升级</para>
            /// </summary>
            [NameInMap("TaskTypeZh")]
            [Validation(Required=false)]
            public string TaskTypeZh { get; set; }

        }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and cannot exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAF88508-D5F8-52B1-8824-262601769E31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of task records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
