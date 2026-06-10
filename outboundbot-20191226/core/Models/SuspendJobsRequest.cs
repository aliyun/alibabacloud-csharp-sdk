// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SuspendJobsRequest : TeaModel {
        /// <summary>
        /// <para>Filter condition: whether to suspend all jobs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef4c09ac-2f5c-49e7-9d33-5d85249cee10</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Filter condition, task group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b3ea2a1-32b3-4041-842b-9bde5de9dda0</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>Job ID list.</para>
        /// <remarks>
        /// <para>When ALL is false, JobId is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11994321-e6bc-47bb-8b1c-8eef8f2f768b</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public List<string> JobId { get; set; }

        /// <summary>
        /// <para>Third-party ID of the job.</para>
        /// <remarks>
        /// <para>This is the ReferenceId uploaded by the customer when uploading the outbound list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>de3ab269-6746-477c-b13d-bd49f13202c2</para>
        /// </summary>
        [NameInMap("JobReferenceId")]
        [Validation(Required=false)]
        public List<string> JobReferenceId { get; set; }

        /// <summary>
        /// <para>Filter condition, scenario ID (historical parameter, deprecated).</para>
        /// 
        /// <b>Example:</b>
        /// <para>4b6dd926-3cc3-4111-a333-15d9b006fe81</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

    }

}
