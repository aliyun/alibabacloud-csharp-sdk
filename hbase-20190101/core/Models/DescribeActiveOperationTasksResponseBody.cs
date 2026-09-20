// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of O&amp;M tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTasksResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the task can be canceled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The task cannot be canceled.</description></item>
            /// <item><description><b>1</b>: The task can be canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowCancel")]
            [Validation(Required=false)]
            public string AllowCancel { get; set; }

            /// <summary>
            /// <para>Indicates whether the time can be modified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The time cannot be modified.</description></item>
            /// <item><description><b>1</b>: The time can be modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowChange")]
            [Validation(Required=false)]
            public string AllowChange { get; set; }

            /// <summary>
            /// <para>The change level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ChangeLevel")]
            [Validation(Required=false)]
            public string ChangeLevel { get; set; }

            /// <summary>
            /// <para>The change level name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Risk repairment</para>
            /// </summary>
            [NameInMap("ChangeLevelEn")]
            [Validation(Required=false)]
            public string ChangeLevelEn { get; set; }

            /// <summary>
            /// <para>The change level name in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>风险修复</para>
            /// </summary>
            [NameInMap("ChangeLevelZh")]
            [Validation(Required=false)]
            public string ChangeLevelZh { get; set; }

            /// <summary>
            /// <para>The time when the O&amp;M task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-15 23:59:59</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The current availability zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-et-a</para>
            /// </summary>
            [NameInMap("CurrentAVZ")]
            [Validation(Required=false)]
            public string CurrentAVZ { get; set; }

            /// <summary>
            /// <para>The database type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>hbaseue</b>: ApsaraDB for HBase Enhanced Edition.</description></item>
            /// <item><description><b>hbase</b>: ApsaraDB for HBase Standard Edition.</description></item>
            /// <item><description><b>bds</b>: BDS data synchronization service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hbaseue</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The database version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>The latest time to which the O&amp;M task execution time can be adjusted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-19 23:59:59</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The O&amp;M task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The business impact in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Transient instance disconnection</para>
            /// </summary>
            [NameInMap("ImpactEn")]
            [Validation(Required=false)]
            public string ImpactEn { get; set; }

            /// <summary>
            /// <para>The business impact in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中断</para>
            /// </summary>
            [NameInMap("ImpactZh")]
            [Validation(Required=false)]
            public string ImpactZh { get; set; }

            /// <summary>
            /// <para>The instance description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--</para>
            /// </summary>
            [NameInMap("InsComment")]
            [Validation(Required=false)]
            public string InsComment { get; set; }

            /// <summary>
            /// <para>The HBase instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ld-bp150tns0sjxs****</para>
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// <para>The time when the O&amp;M task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-19 14:00:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The preparation time required between the start time of the O&amp;M task and the switchover time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14:00:00</para>
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
            /// <para>The description of the execution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The time when the O&amp;M task starts to be executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-19 10:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task running status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: Waiting for the user to specify a time.</description></item>
            /// <item><description><b>3</b>: Waiting for processing.</description></item>
            /// <item><description><b>4</b>: Processing.</description></item>
            /// <item><description><b>5</b>: Succeeded.</description></item>
            /// <item><description><b>6</b>: Failed.</description></item>
            /// <item><description><b>7</b>: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SubInsNames")]
            [Validation(Required=false)]
            public List<string> SubInsNames { get; set; }

            /// <summary>
            /// <para>The time when the system initiates the switchover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-19 14:00:00</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The task type. The value <b>rds_apsaradb_upgrade</b> indicates a minor version upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The task type in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskTypeEn")]
            [Validation(Required=false)]
            public string TaskTypeEn { get; set; }

            /// <summary>
            /// <para>The task type in Chinese.</para>
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
        /// <para>The maximum number of records per page.</para>
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
        /// <para>C634E813-42FA-53D2-A7EB-B881C4B264CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
