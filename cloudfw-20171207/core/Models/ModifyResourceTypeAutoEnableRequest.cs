// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyResourceTypeAutoEnableRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;SlbEIP&quot;:true,&quot;GaEIP&quot;:false,&quot;EcsIPv6&quot;:true,&quot;NatPublicIP&quot;:true,&quot;SlbIPv6&quot;:false,&quot;BastionHostIngressIP&quot;:false,&quot;EIP&quot;:true,&quot;NatEIP&quot;:true,&quot;SlbPublicIP&quot;:true,&quot;EcsEIP&quot;:true,&quot;EniEIP&quot;:true,&quot;HAVIP&quot;:true,&quot;NlbEIP&quot;:true,&quot;NlbIPv6&quot;:false,&quot;EniEIPv6&quot;:false,&quot;EcsPublicIP&quot;:true,&quot;AlbIPv6&quot;:true,&quot;BastionHostIP&quot;:false,&quot;BastionHostEgressIP&quot;:true,&quot;GaEIPV6&quot;:false,&quot;AlbEIP&quot;:false}</para>
        /// </summary>
        [NameInMap("ResourceTypeAutoEnable")]
        [Validation(Required=false)]
        public string ResourceTypeAutoEnable { get; set; }

    }

}
