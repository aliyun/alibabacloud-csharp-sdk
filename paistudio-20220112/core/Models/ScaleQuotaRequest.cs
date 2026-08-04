// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ScaleQuotaRequest : TeaModel {
        /// <summary>
        /// <para>Scaling Min Quota.</para>
        /// <remarks>
        /// <para>Notice: NodeSpecs specifies the post-scaling specifications and quantity. If the Count in NodeSpecs is less than the current Quota\&quot;s Count, it indicates scale-in. Otherwise, it indicates scale-out.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Min")]
        [Validation(Required=false)]
        public ResourceSpec Min { get; set; }

        /// <summary>
        /// <para>Resource group IDs.</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

    }

}
