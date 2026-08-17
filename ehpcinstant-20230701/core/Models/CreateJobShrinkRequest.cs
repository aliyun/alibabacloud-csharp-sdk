// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The dependency policy.</para>
        /// </summary>
        [NameInMap("DependencyPolicy")]
        [Validation(Required=false)]
        public string DependencyPolicyShrink { get; set; }

        /// <summary>
        /// <para>The resource deployment policy.</para>
        /// </summary>
        [NameInMap("DeploymentPolicy")]
        [Validation(Required=false)]
        public string DeploymentPolicyShrink { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// <para>The job name. The name must be 2 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testjob</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("JobScheduler")]
        [Validation(Required=false)]
        public string JobScheduler { get; set; }

        /// <summary>
        /// <para>The job template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jt-xxxx</para>
        /// </summary>
        [NameInMap("JobTemplateId")]
        [Validation(Required=false)]
        public string JobTemplateId { get; set; }

        /// <summary>
        /// <para>The security policy.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public string SecurityPolicyShrink { get; set; }

        /// <summary>
        /// <para>The task list. Currently, only one task is supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public string TasksShrink { get; set; }

    }

}
