// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateJobRequest : TeaModel {
        /// <summary>
        /// <para>The job\&quot;s visibility. You can only increase, not decrease, the visibility. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>PUBLIC</c>: The job is visible to all users in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The job specifications.</para>
        /// </summary>
        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <para>The priority of the job. Valid values range from 1 to 9:</para>
        /// <list type="bullet">
        /// <item><description><para>1 indicates the lowest priority.</para>
        /// </description></item>
        /// <item><description><para>9 indicates the highest priority.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
