// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBatchTasksRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BatchTaskQuery")]
        [Validation(Required=false)]
        public ListBatchTasksRequestBatchTaskQuery BatchTaskQuery { get; set; }
        public class ListBatchTasksRequestBatchTaskQuery : TeaModel {
            [NameInMap("ConditionScheduleEnable")]
            [Validation(Required=false)]
            public bool? ConditionScheduleEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1785930337435</para>
            /// </summary>
            [NameInMap("CreateBeginTime")]
            [Validation(Required=false)]
            public long? CreateBeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788608737435</para>
            /// </summary>
            [NameInMap("CreateEndTime")]
            [Validation(Required=false)]
            public long? CreateEndTime { get; set; }

            [NameInMap("DevelopOwnerList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerList { get; set; }

            [NameInMap("DirectoryList")]
            [Validation(Required=false)]
            public List<string> DirectoryList { get; set; }

            [NameInMap("IncludeSubDirectory")]
            [Validation(Required=false)]
            public bool? IncludeSubDirectory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dwd_order</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            [NameInMap("LastSubmitStatusList")]
            [Validation(Required=false)]
            public List<string> LastSubmitStatusList { get; set; }

            [NameInMap("LockUserList")]
            [Validation(Required=false)]
            public List<string> LockUserList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1785930337435</para>
            /// </summary>
            [NameInMap("ModifiedBeginTime")]
            [Validation(Required=false)]
            public long? ModifiedBeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788608737435</para>
            /// </summary>
            [NameInMap("ModifiedEndTime")]
            [Validation(Required=false)]
            public long? ModifiedEndTime { get; set; }

            [NameInMap("NodeStatusList")]
            [Validation(Required=false)]
            public List<int?> NodeStatusList { get; set; }

            [NameInMap("OpsOwnerList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerList { get; set; }

            [NameInMap("OutputTableNameList")]
            [Validation(Required=false)]
            public List<string> OutputTableNameList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7086194564164288</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("Published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7305621095333696</para>
            /// </summary>
            [NameInMap("RefCodeTemplateId")]
            [Validation(Required=false)]
            public string RefCodeTemplateId { get; set; }

            [NameInMap("ScheduleIntervalTypeList")]
            [Validation(Required=false)]
            public List<string> ScheduleIntervalTypeList { get; set; }

            [NameInMap("TaskStatusList")]
            [Validation(Required=false)]
            public List<int?> TaskStatusList { get; set; }

            [NameInMap("TaskTagList")]
            [Validation(Required=false)]
            public List<string> TaskTagList { get; set; }

            [NameInMap("TaskTypeList")]
            [Validation(Required=false)]
            public List<int?> TaskTypeList { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
