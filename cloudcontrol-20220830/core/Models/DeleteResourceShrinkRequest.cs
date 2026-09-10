// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class DeleteResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure idempotence. This parameter works only if the cloud product supports idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e810dfe1468721d0664a49b9d9f74f4</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required if the cloud product is region-specific.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
