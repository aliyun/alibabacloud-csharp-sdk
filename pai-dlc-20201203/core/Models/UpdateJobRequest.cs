// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateJobRequest : TeaModel {
        /// <summary>
        /// <para>The job visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: The job is visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: The job is visible only to you and the administrator of the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <para>The job priority. Valid values: 1 to 9.</para>
        /// <list type="bullet">
        /// <item><description>1: the lowest priority.</description></item>
        /// <item><description>9: the highest priority.</description></item>
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
