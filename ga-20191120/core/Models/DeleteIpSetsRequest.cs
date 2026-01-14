// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DeleteIpSetsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the acceleration regions that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ips-bp11c9mpphtb1xkds****</para>
        /// </summary>
        [NameInMap("IpSetIds")]
        [Validation(Required=false)]
        public List<string> IpSetIds { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
