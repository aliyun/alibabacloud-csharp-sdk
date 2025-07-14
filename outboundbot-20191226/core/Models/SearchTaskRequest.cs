// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SearchTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("ActualTimeGte")]
        [Validation(Required=false)]
        public long? ActualTimeGte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1643126399000</para>
        /// </summary>
        [NameInMap("ActualTimeLte")]
        [Validation(Required=false)]
        public long? ActualTimeLte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12341155</para>
        /// </summary>
        [NameInMap("CallDurationGte")]
        [Validation(Required=false)]
        public long? CallDurationGte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12341155</para>
        /// </summary>
        [NameInMap("CallDurationLte")]
        [Validation(Required=false)]
        public long? CallDurationLte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15126426342</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d481cebe-0bb6-4d13-9649-42ce5074fb75</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3a30ae7c-27b2-4305-9444-7185ced9d51f</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("JobGroupNameQuery")]
        [Validation(Required=false)]
        public string JobGroupNameQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11994321-e6bc-47bb-8b1c-8eef8f2f768b</para>
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
        /// <para>AVD-2021-39685</para>
        /// </summary>
        [NameInMap("OtherId")]
        [Validation(Required=false)]
        public string OtherId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
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
        /// <para>60</para>
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
        /// <para>1646792941</para>
        /// </summary>
        [NameInMap("TaskCreateTimeGte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeGte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1646792941</para>
        /// </summary>
        [NameInMap("TaskCreateTimeLte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeLte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>744b27f3-437f-4a8c-a181-f668e492fd24</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("TaskStatusStringList")]
        [Validation(Required=false)]
        public string TaskStatusStringList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12341155</para>
        /// </summary>
        [NameInMap("UserIdMatch")]
        [Validation(Required=false)]
        public string UserIdMatch { get; set; }

    }

}
