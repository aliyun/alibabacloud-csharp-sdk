// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ManagedScalingConstraints : TeaModel {
        /// <summary>
        /// <para>最大值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("MaxCapacity")]
        [Validation(Required=false)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// <para>最大按量节点数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxOnDemandCapacity")]
        [Validation(Required=false)]
        public int? MaxOnDemandCapacity { get; set; }

        /// <summary>
        /// <para>最小值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinCapacity")]
        [Validation(Required=false)]
        public int? MinCapacity { get; set; }

    }

}
