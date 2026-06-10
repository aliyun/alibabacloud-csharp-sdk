// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateTaskExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>Start time of the call time range (inclusive)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646496000000</para>
        /// </summary>
        [NameInMap("ActualTimeGte")]
        [Validation(Required=false)]
        public long? ActualTimeGte { get; set; }

        /// <summary>
        /// <para>End time of the call time range (inclusive)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("ActualTimeLte")]
        [Validation(Required=false)]
        public long? ActualTimeLte { get; set; }

        /// <summary>
        /// <para>Minimum call duration</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallDurationGte")]
        [Validation(Required=false)]
        public long? CallDurationGte { get; set; }

        /// <summary>
        /// <para>Maximum call duration</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CallDurationLte")]
        [Validation(Required=false)]
        public long? CallDurationLte { get; set; }

        /// <summary>
        /// <para>Called number</para>
        /// 
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
        /// <para>Whether the call was answered</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAnswered")]
        [Validation(Required=false)]
        public bool? HasAnswered { get; set; }

        /// <summary>
        /// <para>Whether the call ended because the contact rejected it</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasHangUpByRejection")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejection { get; set; }

        /// <summary>
        /// <para>Whether the conversation ended normally</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasReachedEndOfFlow")]
        [Validation(Required=false)]
        public bool? HasReachedEndOfFlow { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1dcb09c5-d5db-4397-bf65-db854463beea</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Task group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb731aee-0a5b-4c2b-924c-d9e82eb1d8d7</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>Task name</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试_20220217_160147</para>
        /// </summary>
        [NameInMap("JobGroupNameQuery")]
        [Validation(Required=false)]
        public string JobGroupNameQuery { get; set; }

        /// <summary>
        /// <para>Job ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>82097dd5-54df-475f-beba-eec8f4b7a3e1</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Job status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusStringList")]
        [Validation(Required=false)]
        public string JobStatusStringList { get; set; }

        /// <summary>
        /// <para>Other ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>64ebe700-91b4-49cb-b457-0b7c0b598a86</para>
        /// </summary>
        [NameInMap("OtherId")]
        [Validation(Required=false)]
        public string OtherId { get; set; }

        /// <summary>
        /// <para>Page number, starting from 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>Number of items per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time for the ring duration search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDurationGte")]
        [Validation(Required=false)]
        public long? RecordingDurationGte { get; set; }

        /// <summary>
        /// <para>End time of the ring duration search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RecordingDurationLte")]
        [Validation(Required=false)]
        public long? RecordingDurationLte { get; set; }

        /// <summary>
        /// <para>Scenario name</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ScriptNameQuery")]
        [Validation(Required=false)]
        public string ScriptNameQuery { get; set; }

        /// <summary>
        /// <para>Sort field</para>
        /// 
        /// <b>Example:</b>
        /// <para>actualTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Sort order. Valid values: asc (ascending), desc (descending)</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>Start time of the task creation time range</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646496000000</para>
        /// </summary>
        [NameInMap("TaskCreateTimeGte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeGte { get; set; }

        /// <summary>
        /// <para>End time of the task creation time range</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("TaskCreateTimeLte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeLte { get; set; }

        /// <summary>
        /// <para>Task ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>64ebe700-91b4-49cb-b457-0b7c0b598a86</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Call status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded,Failed</para>
        /// </summary>
        [NameInMap("TaskStatusStringList")]
        [Validation(Required=false)]
        public string TaskStatusStringList { get; set; }

        /// <summary>
        /// <para>User ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>82097dd5-54df-475f-beba-eec8f4b7a3e1</para>
        /// </summary>
        [NameInMap("UserIdMatch")]
        [Validation(Required=false)]
        public string UserIdMatch { get; set; }

    }

}
