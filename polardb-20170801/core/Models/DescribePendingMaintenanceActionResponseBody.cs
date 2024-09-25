// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePendingMaintenanceActionResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribePendingMaintenanceActionResponseBodyItems> Items { get; set; }
        public class DescribePendingMaintenanceActionResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:42Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The type of the database engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>PostgreSQL</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The version of the database engine.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values for the MySQL database engine:</para>
            /// <list type="bullet">
            /// <item><description><b>5.6</b></description></item>
            /// <item><description><b>5.7</b></description></item>
            /// <item><description><b>8.0</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values for the PostgreSQL database engine:</para>
            /// <list type="bullet">
            /// <item><description><b>11</b></description></item>
            /// <item><description><b>14</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid value for the Oracle database engine: <b>11</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>The deadline before which the task can be executed. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-11T15:59:59Z</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The time when the parameter was modified. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:42Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The preparation time that is required before the pending event is switched. The time follows the <c>HH:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04:00:00</para>
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            /// <summary>
            /// <para>The region ID of the pending event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The execution result of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>manualCancel</b>: The task is manually canceled.</description></item>
            /// <item><description><b>paramCheckNotPass</b>: The task fails to pass the parameter check.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only when the value of the <c>Status</c> parameter is <b>6</b> or <b>7</b>. The value 6 indicates that the task is completed but fails to be executed. The value 7 indicates that the task is canceled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>manualCancel</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The time when the task was executed in the background. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the pending task.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set the <c>IsHistory</c> parameter to <b>0</b>, the status of the pending task is returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: The start time of the task is to be specified.</description></item>
            /// <item><description><b>3</b>: The task is pending.</description></item>
            /// <item><description><b>4</b>: The task is running. In this case, you cannot modify the execution time.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If you set the <c>IsHistory</c> parameter to <b>1</b>, the details of the historical tasks are returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>5</b>: The task is completed and executed.</description></item>
            /// <item><description><b>6</b>: The task is completed but fails to be executed.</description></item>
            /// <item><description><b>7</b>: The task is canceled.</description></item>
            /// </list>
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
            /// <para>The time when the pending event was switched. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T22:00:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The type of the pending event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DatabaseSoftwareUpgrading</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F029645-FED9-4FE8-A6D3-488954******</para>
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
