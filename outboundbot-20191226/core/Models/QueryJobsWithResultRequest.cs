// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsWithResultRequest : TeaModel {
        [NameInMap("EndActualTimeFilter")]
        [Validation(Required=false)]
        public long? EndActualTimeFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAnsweredFilter")]
        [Validation(Required=false)]
        public bool? HasAnsweredFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasHangUpByRejectionFilter")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejectionFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasReachedEndOfFlowFilter")]
        [Validation(Required=false)]
        public bool? HasReachedEndOfFlowFilter { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9d53cd72-4050-4419-8c17-acc0bf158147</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("JobFailureReasonsFilter")]
        [Validation(Required=false)]
        public string JobFailureReasonsFilter { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad16fc35-d824-4102-a606-2be51c1aa6dd</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusFilter")]
        [Validation(Required=false)]
        public string JobStatusFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1882020****</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        [NameInMap("StartActualTimeFilter")]
        [Validation(Required=false)]
        public long? StartActualTimeFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("TaskStatusFilter")]
        [Validation(Required=false)]
        public string TaskStatusFilter { get; set; }

    }

}
