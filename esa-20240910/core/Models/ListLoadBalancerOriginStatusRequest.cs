// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancerOriginStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public string LoadBalancerIds { get; set; }

        [NameInMap("PoolType")]
        [Validation(Required=false)]
        public string PoolType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ListLoadBalancerOriginStatus</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
