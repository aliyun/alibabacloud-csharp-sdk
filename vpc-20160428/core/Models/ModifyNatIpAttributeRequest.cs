// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyNatIpAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: sends a check request without modifying the NAT IP address information. The system checks the request for potential issues, including invalid AccessKey pairs, the authorization status of the RAM user, and missing parameter values. If the request fails the dry run, the corresponding error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, a 2xx HTTP status code is returned and the NAT IP address information is modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The description of the NAT IP address that you want to modify.</para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NatIpDescription")]
        [Validation(Required=false)]
        public string NatIpDescription { get; set; }

        /// <summary>
        /// <para>The instance ID of the NAT IP address that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatip-gw8e1n11f44wpg****</para>
        /// </summary>
        [NameInMap("NatIpId")]
        [Validation(Required=false)]
        public string NatIpId { get; set; }

        /// <summary>
        /// <para>The name of the NAT IP address that you want to modify.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newname</para>
        /// </summary>
        [NameInMap("NatIpName")]
        [Validation(Required=false)]
        public string NatIpName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway instance to which the NAT IP address belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
