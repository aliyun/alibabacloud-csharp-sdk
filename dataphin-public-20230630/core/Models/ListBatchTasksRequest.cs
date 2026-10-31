// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBatchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The task query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BatchTaskQuery")]
        [Validation(Required=false)]
        public ListBatchTasksRequestBatchTaskQuery BatchTaskQuery { get; set; }
        public class ListBatchTasksRequestBatchTaskQuery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable conditional scheduling. If not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("ConditionScheduleEnable")]
            [Validation(Required=false)]
            public bool? ConditionScheduleEnable { get; set; }

            /// <summary>
            /// <para>The start time of the creation time range, in milliseconds. Must be specified together with CreateEndTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785930337435</para>
            /// </summary>
            [NameInMap("CreateBeginTime")]
            [Validation(Required=false)]
            public long? CreateBeginTime { get; set; }

            /// <summary>
            /// <para>The end time of the creation time range, in milliseconds. Must be specified together with CreateBeginTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788608737435</para>
            /// </summary>
            [NameInMap("CreateEndTime")]
            [Validation(Required=false)]
            public long? CreateEndTime { get; set; }

            /// <summary>
            /// <para>The list of developer IDs. If multiple IDs are specified, the union is used. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("DevelopOwnerList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerList { get; set; }

            /// <summary>
            /// <para>The list of task directories, such as [&quot;/&quot;]. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("DirectoryList")]
            [Validation(Required=false)]
            public List<string> DirectoryList { get; set; }

            /// <summary>
            /// <para>Specifies whether to include tasks in the subdirectories of the directories specified in DirectoryList. Default value: false.</para>
            /// </summary>
            [NameInMap("IncludeSubDirectory")]
            [Validation(Required=false)]
            public bool? IncludeSubDirectory { get; set; }

            /// <summary>
            /// <para>The search keyword for fuzzy matching by task name or node ID. If empty or not specified, no filtering is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dwd_order</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The list of recent submit statuses. Valid values: SUBMITTING, SUCCESS, FAILED, and WARNING. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("LastSubmitStatusList")]
            [Validation(Required=false)]
            public List<string> LastSubmitStatusList { get; set; }

            /// <summary>
            /// <para>The list of locker IDs. If multiple IDs are specified, the union is used. If empty or not specified, no filtering by locker is applied.</para>
            /// </summary>
            [NameInMap("LockUserList")]
            [Validation(Required=false)]
            public List<string> LockUserList { get; set; }

            /// <summary>
            /// <para>The start time of the last modification time range, in milliseconds. Must be specified together with ModifiedEndTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785930337435</para>
            /// </summary>
            [NameInMap("ModifiedBeginTime")]
            [Validation(Required=false)]
            public long? ModifiedBeginTime { get; set; }

            /// <summary>
            /// <para>The end time of the last modification time range, in milliseconds. Must be specified together with ModifiedBeginTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788608737435</para>
            /// </summary>
            [NameInMap("ModifiedEndTime")]
            [Validation(Required=false)]
            public long? ModifiedEndTime { get; set; }

            /// <summary>
            /// <para>The list of scheduling types. Valid values: 0 (Manual), 1 (Normal), 2 (Paused), and 3 (Dry run). If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("NodeStatusList")]
            [Validation(Required=false)]
            public List<int?> NodeStatusList { get; set; }

            /// <summary>
            /// <para>The list of O&amp;M owner IDs. If multiple IDs are specified, the union is used. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("OpsOwnerList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerList { get; set; }

            /// <summary>
            /// <para>The list of output table names for exact matching. If multiple table names are specified, the OR logical operator is used. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("OutputTableNameList")]
            [Validation(Required=false)]
            public List<string> OutputTableNameList { get; set; }

            /// <summary>
            /// <para>The page number. Pages start from 1. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The project ID. The query scope is limited to this project.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7086194564164288</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Specifies whether the task is published to the production environment. If not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("Published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

            /// <summary>
            /// <para>The ID of the referenced offline code template. If empty or not specified, no filtering is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7305621095333696</para>
            /// </summary>
            [NameInMap("RefCodeTemplateId")]
            [Validation(Required=false)]
            public string RefCodeTemplateId { get; set; }

            /// <summary>
            /// <para>The list of scheduling intervals. Valid values: MINUTELY, HOURLY, DAILY, WEEKLY, and MONTHLY. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("ScheduleIntervalTypeList")]
            [Validation(Required=false)]
            public List<string> ScheduleIntervalTypeList { get; set; }

            /// <summary>
            /// <para>The list of task statuses. Valid values: 0 (Draft), 1 (Submitting), 2 (Submitted), and 100 (In development). If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("TaskStatusList")]
            [Validation(Required=false)]
            public List<int?> TaskStatusList { get; set; }

            /// <summary>
            /// <para>The list of task tag names. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("TaskTagList")]
            [Validation(Required=false)]
            public List<string> TaskTagList { get; set; }

            /// <summary>
            /// <para>The list of task type codes. If empty or not specified, no filtering is applied.</para>
            /// </summary>
            [NameInMap("TaskTypeList")]
            [Validation(Required=false)]
            public List<int?> TaskTypeList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
