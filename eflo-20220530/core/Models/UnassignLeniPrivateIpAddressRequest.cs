// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UnassignLeniPrivateIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The idempotent identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>967e77a2-b61d-11ec-a147-0242c0a80504</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Lingjun Elastic Network Interface ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>leni-1234****</para>
        /// </summary>
        [NameInMap("ElasticNetworkInterfaceId")]
        [Validation(Required=false)]
        public string ElasticNetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>Lingjun Elastic Network Interface secondary private IP unique identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sip-8ylg****</para>
        /// </summary>
        [NameInMap("IpName")]
        [Validation(Required=false)]
        public string IpName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
