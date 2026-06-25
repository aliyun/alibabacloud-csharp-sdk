// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class DeleteWorkflowsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-a1804a3226d</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>If set to <c>true</c>, all jobs within the specified workflows are also deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteJobs")]
        [Validation(Required=false)]
        public bool? DeleteJobs { get; set; }

        /// <summary>
        /// <para>A list of workflow IDs to delete.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkflowIds")]
        [Validation(Required=false)]
        public string WorkflowIdsShrink { get; set; }

    }

}
