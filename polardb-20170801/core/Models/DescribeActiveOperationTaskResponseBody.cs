// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
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
            /// <para>The time when the task was created. The time is displayed in the <c>yyyy-MM-ddTHH:mmZ</c> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:42Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_mysql</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>The latest deadline within the adjustable range for task execution time. The time is displayed in the <c>yyyy-MM-ddTHH:mmZ</c> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-11T15:59:59Z</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// <para>The time when the task was modified. The time is displayed in the <c>yyyy-MM-ddTHH:mmZ</c> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:42Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The preparation time before the transient disconnection. The time is displayed in the <c>HH:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04:00:00</para>
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            /// <summary>
            /// <para>The region where the task is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The task execution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The time when the task is executed in the background. The time is displayed in the <c>yyyy-MM-ddTHH:mmZ</c> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set <c>IsHistory</c> to <b>0</b>, the details of the pending task status are returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: Waiting for the user to set the task start time.</description></item>
            /// <item><description><b>3</b>: Waiting to be processed.</description></item>
            /// <item><description><b>4</b>: The task is being processed.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If you set <c>IsHistory</c> to <b>1</b>, the details of the historical task status are returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>5</b>: The task is completed and executed successfully.</description></item>
            /// <item><description><b>6</b>: The task is completed but failed.</description></item>
            /// <item><description><b>7</b>: The task is canceled.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when the transient disconnection occurs. The time is displayed in the <c>yyyy-MM-ddTHH:mmZ</c> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The task parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;action\&quot;: \&quot;UpgradeDBVersion\&quot;, \&quot;check_method\&quot;: \&quot;check_cpu_usage\&quot;, \&quot;params\&quot;: {\&quot;RelativeDbtype\&quot;: \&quot;maxscale\&quot;, \&quot;DBInstanceName\&quot;: \&quot;pc-*************\&quot;, \&quot;User_ID\&quot;: \&quot;11111\&quot;, \&quot;UID\&quot;: \&quot;1406926474******\&quot;, \&quot;UpgradePolicy\&quot;: \&quot;hot\&quot;}}&quot;</para>
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

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
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED2BD080-F9D9-4822-ACBB-AE5D87******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
