// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateJobRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the job can only be increased, not decreased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: The job is visible to all users in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The description of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a training job</para>
        /// </summary>
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
        /// <para>The priority of the job. Valid values: 1 to 9.</para>
        /// <list type="bullet">
        /// <item><description>1: The lowest priority.</description></item>
        /// <item><description>9: The highest priority.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The user command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sleep 1d</para>
        /// </summary>
        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public string UserCommand { get; set; }

    }

}
