// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SelfQuotaPreemptionConfig : TeaModel {
        /// <summary>
        /// <para>The priorities that can be preempted.</para>
        /// </summary>
        [NameInMap("PreemptedPriorities")]
        [Validation(Required=false)]
        public List<int?> PreemptedPriorities { get; set; }

        /// <summary>
        /// <para>The task types that can be preempted.</para>
        /// </summary>
        [NameInMap("PreemptedProducts")]
        [Validation(Required=false)]
        public List<string> PreemptedProducts { get; set; }

        /// <summary>
        /// <para>The priorities that can initiate preemption.</para>
        /// </summary>
        [NameInMap("PreemptorPriorities")]
        [Validation(Required=false)]
        public List<int?> PreemptorPriorities { get; set; }

    }

}
