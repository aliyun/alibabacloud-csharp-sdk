// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried O\&amp;M tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTasksResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the O\&amp;M task can be canceled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no.</description></item>
            /// <item><description>1: yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowCancel")]
            [Validation(Required=false)]
            public string AllowCancel { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution time of the O\&amp;M task can be changed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no.</description></item>
            /// <item><description>1: yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AllowChange")]
            [Validation(Required=false)]
            public string AllowChange { get; set; }

            /// <summary>
            /// <para>The trigger level of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ChangeLevel")]
            [Validation(Required=false)]
            public string ChangeLevel { get; set; }

            /// <summary>
            /// <para>The trigger level of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Risk repairment</para>
            /// </summary>
            [NameInMap("ChangeLevelEn")]
            [Validation(Required=false)]
            public string ChangeLevelEn { get; set; }

            /// <summary>
            /// <para>The trigger level of the O\&amp;M task in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System maintenance</para>
            /// </summary>
            [NameInMap("ChangeLevelZh")]
            [Validation(Required=false)]
            public string ChangeLevelZh { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-k</para>
            /// </summary>
            [NameInMap("CurrentAVZ")]
            [Validation(Required=false)]
            public string CurrentAVZ { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>analyticdb</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The database version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.0</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>The end time of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// <para>The O\&amp;M task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2389899</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The impact of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TransientDisconnectionAndMinorVersionUpgrade</para>
            /// </summary>
            [NameInMap("Impact")]
            [Validation(Required=false)]
            public string Impact { get; set; }

            /// <summary>
            /// <para>The impact of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Transient instance disconnection, minor version upgrade</para>
            /// </summary>
            [NameInMap("ImpactEn")]
            [Validation(Required=false)]
            public string ImpactEn { get; set; }

            /// <summary>
            /// <para>The impact of the O\&amp;M task in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service interruption and minor version update</para>
            /// </summary>
            [NameInMap("ImpactZh")]
            [Validation(Required=false)]
            public string ImpactZh { get; set; }

            /// <summary>
            /// <para>The description of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("InsComment")]
            [Validation(Required=false)]
            public string InsComment { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>am-2ze307ym37t762hnl</para>
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The preparation time period for the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03:00:00</para>
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The response message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The start time of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the O\&amp;M task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>3: pending.</description></item>
            /// <item><description>4: executing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The child instance IDs.</para>
            /// </summary>
            [NameInMap("SubInsNames")]
            [Validation(Required=false)]
            public List<string> SubInsNames { get; set; }

            /// <summary>
            /// <para>The time when the switchover was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>The parameters of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;outer_user_params\&quot;:{\&quot;TargetMinorVersion\&quot;:\&quot;3.2.2.6\&quot;,\&quot;detailCode\&quot;:\&quot;OldKernelVersionUpgrade\&quot;,\&quot;cancelCode\&quot;:\&quot;OutOfNewFeatureAndStability\&quot;},\&quot;params\&quot;:{},\&quot;internal_params\&quot;:{\&quot;instanceInfo\&quot;:[],\&quot;destHostInfo\&quot;:[]}}</para>
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// <para>The type of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The type of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Minor version update</para>
            /// </summary>
            [NameInMap("TaskTypeEn")]
            [Validation(Required=false)]
            public string TaskTypeEn { get; set; }

            /// <summary>
            /// <para>The type of the O\&amp;M task in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Minor version update</para>
            /// </summary>
            [NameInMap("TaskTypeZh")]
            [Validation(Required=false)]
            public string TaskTypeZh { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>421794A3-72A5-5D27-9E8B-A75A4C503E17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
