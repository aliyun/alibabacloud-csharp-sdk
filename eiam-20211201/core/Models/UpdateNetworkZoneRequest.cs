// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateNetworkZoneRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>client-token-examplexxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>包含的CIDR</para>
        /// </summary>
        [NameInMap("Ipv4Cidrs")]
        [Validation(Required=false)]
        public List<string> Ipv4Cidrs { get; set; }

        /// <summary>
        /// <para>网络区域ipv6Cidr</para>
        /// </summary>
        [NameInMap("Ipv6Cidrs")]
        [Validation(Required=false)]
        public List<string> Ipv6Cidrs { get; set; }

        /// <summary>
        /// <para>IDaaS的网络区域主键id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>network_11111</para>
        /// </summary>
        [NameInMap("NetworkZoneId")]
        [Validation(Required=false)]
        public string NetworkZoneId { get; set; }

        /// <summary>
        /// <para>网络区域名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4Test</para>
        /// </summary>
        [NameInMap("NetworkZoneName")]
        [Validation(Required=false)]
        public string NetworkZoneName { get; set; }

        /// <summary>
        /// <para>专有网络VpcId</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_xxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
