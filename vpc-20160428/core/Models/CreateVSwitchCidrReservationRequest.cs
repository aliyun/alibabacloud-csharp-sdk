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
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
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
        /// <item><description><b>true</b>: sends a check request without creating the reserved CIDR block for a vSwitch. The system checks whether the required parameters are specified, the request format is valid, and the service limits are not exceeded. If the check fails, the corresponding error is returned. If the check passes, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a Normal request. After the check passes, an HTTP 2xx status code is returned and the reserved CIDR block for a vSwitch is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The IP version of the reserved CIDR block for a vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b> (default)</description></item>
        /// <item><description><b>IPv6</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>You do not need to specify this parameter when creating an IPv4 reserved CIDR block for a vSwitch. This parameter is required when creating an IPv6 reserved CIDR block for a vSwitch.</para>
        /// </remarks>
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
        /// <para>The region ID of the vSwitch.</para>
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
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVSwitchCidrReservationRequestTag> Tag { get; set; }
        public class CreateVSwitchCidrReservationRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, the value cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, the value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The reserved CIDR block for a vSwitch.</para>
        /// <list type="bullet">
        /// <item><description>If <b>IpVersion</b> is set to <b>IPv4</b>, the reserved CIDR block for a vSwitch must be a proper subset of the IPv4 CIDR block of the vSwitch, and the mask length cannot exceed 28.</description></item>
        /// <item><description>If <b>IpVersion</b> is set to <b>IPv6</b>, the reserved CIDR block for a vSwitch must be a proper subset of the IPv6 CIDR block of the vSwitch, and the mask length cannot exceed 80.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify either the <b>VSwitchCidrReservationMask</b> parameter or the <b>VSwitchCidrReservationCidr</b> parameter.</description></item>
        /// <item><description>A reserved CIDR block cannot contain the system reserved IP addresses of the vSwitch to which it belongs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.64/28</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationCidr")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationCidr { get; set; }

        /// <summary>
        /// <para>The description of the reserved CIDR block for a vSwitch. If you leave this parameter empty, the default value is empty.</para>
        /// <para>The description must be 1 to 256 characters in length and must start with a letter or Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReservationDescription</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationDescription")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationDescription { get; set; }

        /// <summary>
        /// <para>The mask of the reserved CIDR block for a vSwitch.</para>
        /// <list type="bullet">
        /// <item><description>If <b>IpVersion</b> is set to <b>IPv4</b>, the mask length of the reserved CIDR block must be at least 2 bits longer than the IPv4 CIDR block mask of the vSwitch and cannot exceed 28.</description></item>
        /// <item><description>If <b>IpVersion</b> is set to <b>IPv6</b>, the mask length of the reserved CIDR block must be longer than the IPv6 CIDR block mask of the vSwitch and cannot exceed 80.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify either the <b>VSwitchCidrReservationMask</b> parameter or the <b>VSwitchCidrReservationCidr</b> parameter.</description></item>
        /// <item><description>A reserved CIDR block cannot contain the system reserved IP addresses of the vSwitch to which it belongs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationMask")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationMask { get; set; }

        /// <summary>
        /// <para>The name of the reserved CIDR block for a vSwitch.</para>
        /// <para>The name must be 1 to 128 characters in length and must start with a letter or Chinese character. It can contain digits, underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReservationName</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationName")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationName { get; set; }

        /// <summary>
        /// <para>The type of the reserved CIDR block for a vSwitch. Valid values: <b>prefix</b>, which indicates that addresses are allocated by CIDR block.</para>
        /// <remarks>
        /// <para>When users or cloud services automatically assign CIDR blocks to elastic network interfaces (ENIs), the CIDR blocks must be allocated from the reserved CIDR block. If the addresses in the reserved CIDR block are exhausted, the system returns an error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>prefix</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationType")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch for which you want to create the reserved CIDR block for a vSwitch.</para>
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
