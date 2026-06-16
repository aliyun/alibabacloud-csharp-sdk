// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateNetworkZoneRequest : TeaModel {
        /// <summary>
        /// <para>The idempotence token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the network zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR blocks of the network zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("Ipv4Cidrs")]
        [Validation(Required=false)]
        public List<string> Ipv4Cidrs { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR blocks of the network zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>::/0</para>
        /// </summary>
        [NameInMap("Ipv6Cidrs")]
        [Validation(Required=false)]
        public List<string> Ipv6Cidrs { get; set; }

        /// <summary>
        /// <para>The name of the network zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4Test</para>
        /// </summary>
        [NameInMap("NetworkZoneName")]
        [Validation(Required=false)]
        public string NetworkZoneName { get; set; }

        /// <summary>
        /// <para>The type of the network zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:alibaba:idaas:network:zone:classic</para>
        /// </summary>
        [NameInMap("NetworkZoneType")]
        [Validation(Required=false)]
        public string NetworkZoneType { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_xxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
