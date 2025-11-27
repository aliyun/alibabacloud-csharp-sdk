// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DeleteJobsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of executor IDs. A maximum of 100 IDs are supported.</para>
        /// </summary>
        [NameInMap("ExecutorIds")]
        [Validation(Required=false)]
        public string ExecutorIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the job scheduler.</para>
        /// <list type="bullet">
        /// <item><description>HPC</description></item>
        /// <item><description>K8S</description></item>
        /// </list>
        /// <para>Default value: HPC</para>
        /// 
        /// <b>Example:</b>
        /// <para>HPC</para>
        /// </summary>
        [NameInMap("JobScheduler")]
        [Validation(Required=false)]
        public string JobScheduler { get; set; }

        /// <summary>
        /// <para>The information about the job to be deleted.</para>
        /// </summary>
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public string JobSpecShrink { get; set; }

    }

}
