// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CancelJobsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to cancel all jobs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A filter condition. The task group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f84892d-721a-4069-9975-668c8164d64e</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>A filter condition. The job ID.</para>
        /// <remarks>
        /// <para>The JobId parameter is required when the All parameter is set to false.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>edf45790-7200-4cbc-b157-8c0a5f400b75</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public List<string> JobId { get; set; }

        /// <summary>
        /// <para>A filter condition. The reference ID of the job.</para>
        /// <remarks>
        /// <para>This is the ReferenceId that you specified when you uploaded the contact list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4a875676-b136-4087-88b4-de67c61fed69</para>
        /// </summary>
        [NameInMap("JobReferenceId")]
        [Validation(Required=false)]
        public List<string> JobReferenceId { get; set; }

        /// <summary>
        /// <para>A filter condition. The scenario ID.</para>
        /// <remarks>
        /// <para>Obtain this ID by calling the DescribeJobGroup operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>35641113-b2f6-464e-a772-25c25554798b</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

    }

}
