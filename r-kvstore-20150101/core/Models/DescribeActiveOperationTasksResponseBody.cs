// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of O&amp;M events.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTasksResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the event can be canceled. A value of 1 indicates that the event can be canceled. A value of 0 indicates that the event cannot be canceled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowCancel")]
            [Validation(Required=false)]
            public string AllowCancel { get; set; }

            /// <summary>
            /// <para>Indicates whether the event time can be modified. A value of 1 indicates that the time can be modified. A value of 0 indicates that the time cannot be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowChange")]
            [Validation(Required=false)]
            public string AllowChange { get; set; }

            /// <summary>
            /// <para>The event level code. S1 indicates system O&amp;M. S0 indicates risk recovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S1</para>
            /// </summary>
            [NameInMap("ChangeLevel")]
            [Validation(Required=false)]
            public string ChangeLevel { get; set; }

            /// <summary>
            /// <para>The event level in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System maintenance</para>
            /// </summary>
            [NameInMap("ChangeLevelEn")]
            [Validation(Required=false)]
            public string ChangeLevelEn { get; set; }

            /// <summary>
            /// <para>The event level in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>系统运维</para>
            /// </summary>
            [NameInMap("ChangeLevelZh")]
            [Validation(Required=false)]
            public string ChangeLevelZh { get; set; }

            /// <summary>
            /// <para>The creation time in UTC. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
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
            /// <para>The database type. Return value: <b>redis</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The Milvus version number of the kernel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>The latest deadline by which the task execution time can be adjusted, in UTC. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T23:59:59Z</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The O&amp;M event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

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
            /// <para>The event impact in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Transient instance disconnection</para>
            /// </summary>
            [NameInMap("ImpactEn")]
            [Validation(Required=false)]
            public string ImpactEn { get; set; }

            /// <summary>
            /// <para>The event impact in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>实例闪断</para>
            /// </summary>
            [NameInMap("ImpactZh")]
            [Validation(Required=false)]
            public string ImpactZh { get; set; }

            /// <summary>
            /// <para>The instance alias or description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InsComment")]
            [Validation(Required=false)]
            public string InsComment { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1lgal1sdvxrz****</para>
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// <para>The modification time in UTC. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The preparation time required between the start time and the switchover time. Format: HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04:00:00</para>
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
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
            /// <para>The time when the backend starts executing the event, in UTC. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T00:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the O&amp;M event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: pending.</description></item>
            /// <item><description><b>4</b>: being processed.</description></item>
            /// <item><description><b>5</b>: ended successfully.</description></item>
            /// <item><description><b>6</b>: ended with failure.</description></item>
            /// <item><description><b>7</b>: canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The list of sub-events.</para>
            /// </summary>
            [NameInMap("SubInsNames")]
            [Validation(Required=false)]
            public List<string> SubInsNames { get; set; }

            /// <summary>
            /// <para>The time when the backend initiates the switchover operation, in UTC. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The O&amp;M event parameters.</para>
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
            /// <para>The type of the O&amp;M event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_transfer</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The reason for the O&amp;M event in English.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 25.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D9F3768-EDA9-4811-943E-42C8006E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of O&amp;M event records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
