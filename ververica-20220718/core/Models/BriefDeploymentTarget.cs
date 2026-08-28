// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class BriefDeploymentTarget : TeaModel {
        /// <summary>
        /// <para>The deployment mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PER_JOB</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The name of the queue used for the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvp-workload</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
