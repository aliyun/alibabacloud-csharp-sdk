// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodePodsRequest : TeaModel {
        /// <summary>
        /// <para>The GPU index number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GPUIndexes")]
        [Validation(Required=false)]
        public string GPUIndexes { get; set; }

        /// <summary>
        /// <para>The resource type used by the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ForceQuotaOversold</para>
        /// </summary>
        [NameInMap("OversoldTypes")]
        [Validation(Required=false)]
        public string OversoldTypes { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the node belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingj19q90jp66nq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
