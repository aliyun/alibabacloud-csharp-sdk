// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ManagedScalingConstraints : TeaModel {
        /// <summary>
        /// <para>The maximum number of nodes in a node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("MaxCapacity")]
        [Validation(Required=false)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// <para>The maximum number of pay-as-you-go task nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxOnDemandCapacity")]
        [Validation(Required=false)]
        public int? MaxOnDemandCapacity { get; set; }

        /// <summary>
        /// <para>The minimum number of nodes in a node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinCapacity")]
        [Validation(Required=false)]
        public int? MinCapacity { get; set; }

    }

}
