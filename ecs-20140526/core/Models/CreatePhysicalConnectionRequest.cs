// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreatePhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The access point ID. You can call the <c>DescribeAccessPoints</c> operation to obtain a list of available access points.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>The circuit code provided by the carrier.</para>
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// <para>A client-generated token that you can use to ensure the idempotency of the request. This token must be unique across requests, contain only ASCII characters, and be no more than 64 characters long.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the physical connection. The description must be 2 to 256 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The carrier that provides the physical connection. Valid values: <c>CT</c> (China Telecom), <c>CU</c> (China Unicom), <c>CM</c> (China Mobile), <c>CO</c> (other Chinese carriers), and <c>AL</c> (Alibaba Cloud).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LineOperator")]
        [Validation(Required=false)]
        public string LineOperator { get; set; }

        /// <summary>
        /// <para>The name of the physical connection. The name must be 2 to 128 characters long. It must start with a letter and can contain letters, digits, underscores (<c>_</c>), and hyphens (<c>-</c>).</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The physical location of your on-premises data center.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// <para>The port type of the physical connection. You cannot change this parameter after the physical connection is created. Valid values: <c>1000Base-LX</c> (1 Gbit/s), <c>10GBase-LR</c> (10 Gbit/s), and <c>40GBase-LR</c> (40 Gbit/s).</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The ID of the redundant physical connection. The redundant physical connection must be in the <c>Allocated</c>, <c>Confirmed</c>, or <c>Enabled</c> state.</para>
        /// </summary>
        [NameInMap("RedundantPhysicalConnectionId")]
        [Validation(Required=false)]
        public string RedundantPhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The ID of the region for the physical connection. You can call the <c>DescribeRegions</c> operation to obtain the latest list of regions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the physical connection. Valid values: <c>VPC</c> and <c>VBR</c>. The default value is <c>VPC</c>. This parameter is available only to whitelisted users.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The user CIDR block. This parameter is required when <c>Type</c> is set to <c>VPC</c>. The CIDR block must be a private IPv4 block. Valid CIDR blocks include the following blocks and their subnets: <c>10.0.0.0/8</c>, <c>172.16.0.0/12</c>, and <c>192.168.0.0/16</c>.</para>
        /// </summary>
        [NameInMap("UserCidr")]
        [Validation(Required=false)]
        public string UserCidr { get; set; }

        /// <summary>
        /// <para>The bandwidth of the physical connection in Mbit/s. The value must be an integer that ranges from 1 to 10,240.</para>
        /// </summary>
        [NameInMap("bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

    }

}
