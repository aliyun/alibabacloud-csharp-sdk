// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTaskResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the O&amp;M task was created. The format is <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-06T13:11:08Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mongodb</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The latest time within the adjustable range for the execution time of the O&amp;M task. The format is <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-29T13:59:59Z</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50xx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dds-bp12721xxxx9b914</para>
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// <para>The time when the O&amp;M task was modified. The format is <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-24T08:18:53Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The preparation time required between the start time and the switchover time of the O&amp;M task. The format is HH:mm:ss.</para>
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
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The execution result information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The execution time of the O&amp;M task. The format is <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-20T02:40:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: Waiting for the user to specify a time.</description></item>
            /// <item><description>3: Waiting to be processed.</description></item>
            /// <item><description>4: Processing. After the task enters this state, the scheduled switchover time cannot be modified.</description></item>
            /// <item><description>5: Succeeded.</description></item>
            /// <item><description>6: Failed.</description></item>
            /// <item><description>7: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The switchover time of the O&amp;M task. The format is <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-06T14:11:08Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The task parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>rds_apsaradb_ha: primary/secondary node switch.</description></item>
            /// <item><description>rds_apsaradb_transfer: instance migration.</description></item>
            /// <item><description>rds_apsaradb_upgrade: minor version update.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_ha</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: 30.</para>
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
        /// <para>6FD47DC4-0750-5524-A89E-E7D559Cxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
