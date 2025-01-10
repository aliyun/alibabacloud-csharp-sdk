// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetLniPrivateIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>IP unique identifier</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sip-xxxxx</para>
        /// </summary>
        [NameInMap("IpName")]
        [Validation(Required=false)]
        public string IpName { get; set; }

        /// <summary>
        /// <para>Lingjun network interface controller ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lni-bp18exxqa2rvfn45e5pz</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

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
