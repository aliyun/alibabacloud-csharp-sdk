// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatIpAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Client Token, used to ensure the idempotence of requests. Generate a unique value for this parameter from your client, ensuring that it is unique across different requests. ClientToken only supports ASCII characters. If not specified, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b> identifier. The <b>RequestId</b> may differ for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Indicates whether to perform a dry run of the request. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sends a check request without querying NAT IP address information. The checks include whether the AccessKey is valid, the RAM user\&quot;s authorization status, and if all required parameters are filled out. If any check fails, the corresponding error is returned. If all checks pass, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): Sends a normal request. After passing the checks, it returns an HTTP 2xx status code and queries the NAT IP address information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the NAT IP address instance to be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatip-gw8y7q3cpk3fggs87****</para>
        /// </summary>
        [NameInMap("NatIpId")]
        [Validation(Required=false)]
        public string NatIpId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway instance to which the NAT IP address to be queried belongs. You can obtain the region ID by calling the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eu-central-1</para>
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

    }

}
