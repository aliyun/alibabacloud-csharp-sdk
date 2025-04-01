// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of O\&amp;M tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTaskResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the O\&amp;M task was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-15 23:59:59</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The database type of the instance. The return value is <b>Redis</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The deadline before which the time to preform the O&amp;M task can be modified. The time in UTC is displayed in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-19 23:59:59</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The ID of the O&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1lgal1sdvxrz****</para>
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-19 14:00:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The required preparation period between the task start time and the switchover time. The time is displayed in the <em>HH:mm:ss</em> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14:00:00</para>
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was preformed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-19 10:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The state of the O&amp;M task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: The task is waiting for users to specify a switchover time.</description></item>
            /// <item><description><b>3</b>: The task is waiting to be performed.</description></item>
            /// <item><description><b>4</b>: The task is being performed. If the task is in this state, the <b>ModifyActiveOperationTask</b> operation cannot be called to modify the scheduled switchover time.</description></item>
            /// <item><description><b>5</b>: The task is performed.</description></item>
            /// <item><description><b>6</b>: The task fails.</description></item>
            /// <item><description><b>7</b>: The task is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when the system performs the switchover operation. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-19 14:00:00</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>rds_apsaradb_ha</b>: master-replica switchover</description></item>
            /// <item><description><b>rds_apsaradb_transfer</b>: instance migration</description></item>
            /// <item><description><b>rds_apsaradb_upgrade</b>: minor version update</description></item>
            /// <item><description><b>all</b>: all types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E1FF0CC-F42A-4B6F-A1F4-A17B1451****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
