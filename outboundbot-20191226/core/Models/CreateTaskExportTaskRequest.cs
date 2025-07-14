// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateTaskExportTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1646496000000</para>
        /// </summary>
        [NameInMap("ActualTimeGte")]
        [Validation(Required=false)]
        public long? ActualTimeGte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("ActualTimeLte")]
        [Validation(Required=false)]
        public long? ActualTimeLte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallDurationGte")]
        [Validation(Required=false)]
        public long? CallDurationGte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CallDurationLte")]
        [Validation(Required=false)]
        public long? CallDurationLte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111111111</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAnswered")]
        [Validation(Required=false)]
        public bool? HasAnswered { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasHangUpByRejection")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasReachedEndOfFlow")]
        [Validation(Required=false)]
        public bool? HasReachedEndOfFlow { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1dcb09c5-d5db-4397-bf65-db854463beea</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cb731aee-0a5b-4c2b-924c-d9e82eb1d8d7</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("JobGroupNameQuery")]
        [Validation(Required=false)]
        public string JobGroupNameQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82097dd5-54df-475f-beba-eec8f4b7a3e1</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusStringList")]
        [Validation(Required=false)]
        public string JobStatusStringList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64ebe700-91b4-49cb-b457-0b7c0b598a86</para>
        /// </summary>
        [NameInMap("OtherId")]
        [Validation(Required=false)]
        public string OtherId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDurationGte")]
        [Validation(Required=false)]
        public long? RecordingDurationGte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RecordingDurationLte")]
        [Validation(Required=false)]
        public long? RecordingDurationLte { get; set; }

        [NameInMap("ScriptNameQuery")]
        [Validation(Required=false)]
        public string ScriptNameQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>actualTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1646496000000</para>
        /// </summary>
        [NameInMap("TaskCreateTimeGte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeGte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("TaskCreateTimeLte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeLte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64ebe700-91b4-49cb-b457-0b7c0b598a86</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded,Failed</para>
        /// </summary>
        [NameInMap("TaskStatusStringList")]
        [Validation(Required=false)]
        public string TaskStatusStringList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82097dd5-54df-475f-beba-eec8f4b7a3e1</para>
        /// </summary>
        [NameInMap("UserIdMatch")]
        [Validation(Required=false)]
        public string UserIdMatch { get; set; }

    }

}
