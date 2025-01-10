// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UnAssignPrivateIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>By default, popApi is not ignored and idempotent</para>
        /// 
        /// <b>Example:</b>
        /// <para>141cccd6-dfbd-11ec-b8e8-0242ac110003</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>IP unique identifier</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sip-xxxx</para>
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
        /// <para>The private IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.209.75.242</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>Region</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Subnet</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subnet-f3zfzmnc</para>
        /// </summary>
        [NameInMap("SubnetId")]
        [Validation(Required=false)]
        public string SubnetId { get; set; }

    }

}
