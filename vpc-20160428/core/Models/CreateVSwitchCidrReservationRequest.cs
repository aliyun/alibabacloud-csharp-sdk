// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVSwitchCidrReservationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run, without performing the actual request. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The IP version of the reserved CIDR block. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b> (default)</description></item>
        /// <item><description><b>IPv6</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the vSwitch is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>Resource tags</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVSwitchCidrReservationRequestTag> Tag { get; set; }
        public class CreateVSwitchCidrReservationRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the resource. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The reserved CIDR block of the vSwitch.</para>
        /// <list type="bullet">
        /// <item><description>When <b>IpVersion</b> is set to <b>IPv4</b>, the reserved CIDR block must be a proper subset of the IPv4 CIDR block of the vSwitch and the subnet mask length of the reserved CIDR block cannot be greater than 28.</description></item>
        /// <item><description>When <b>IpVersion</b> is set to <b>IPv6</b>, the reserved CIDR block must be a proper subset of the IPv6 CIDR block of the vSwitch and the subnet mask length of the reserved CIDR block cannot be greater than 80.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify one of <b>VSwitchCidrReservationMask</b> and <b>VSwitchCidrReservationCidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.64/28</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationCidr")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationCidr { get; set; }

        /// <summary>
        /// <para>The description of the reserved CIDR block. This parameter is empty by default.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReservationDescription</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationDescription")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationDescription { get; set; }

        /// <summary>
        /// <para>The subnet mask of the reserved CIDR block.</para>
        /// <list type="bullet">
        /// <item><description>When <b>IpVersion</b> is set to <b>IPv4</b>, the subnet mask length of the CIDR block must be greater than the IPv4 subnet mask length of the vSwitch and cannot be greater than 28.</description></item>
        /// <item><description>When <b>IpVersion</b> is set to <b>IPv6</b>, the subnet mask length of the CIDR block must be greater than the IPv6 subnet mask length of the vSwitch and cannot be greater than 80.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify one of <b>VSwitchCidrReservationMask</b> and <b>VSwitchCidrReservationCidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationMask")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationMask { get; set; }

        /// <summary>
        /// <para>The name of the reserved CIDR block.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain digits, underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReservationName</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationName")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationName { get; set; }

        /// <summary>
        /// <para>The type of reserved CIDR block. Set the value to <b>prefix</b>.</para>
        /// <remarks>
        /// <para> When a user or a cloud service allocates a CIDR block to an elastic network interface (ENI), the CIDR block must be allocated from the reserved CIDR block. If the reserved CIDR block is exhausted, an error is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>prefix</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationType")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the reserved CIDR block belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-25navfgbue4g****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
