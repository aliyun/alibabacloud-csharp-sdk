// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVSwitchCidrReservationsRequest : TeaModel {
        /// <summary>
        /// <para>The IP version of the reserved CIDR block for a vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b> (default): IPv4.</description></item>
        /// <item><description><b>IPv6</b>: IPv6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first request or no subsequent query exists, leave this parameter empty.</description></item>
        /// <item><description>If a subsequent query exists, set this parameter to the NextToken value returned in the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the vSwitch.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The tag information.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListVSwitchCidrReservationsRequestTags> Tags { get; set; }
        public class ListVSwitchCidrReservationsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, the value cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, the value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance IDs of the reserved CIDR block for a vSwitch. You can specify up to 10 reserved CIDR blocks.</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationIds")]
        [Validation(Required=false)]
        public List<string> VSwitchCidrReservationIds { get; set; }

        /// <summary>
        /// <para>The type of the reserved CIDR block for a vSwitch. Valid values: <b>prefix</b>, which indicates that addresses are allocated by CIDR block.</para>
        /// <remarks>
        /// <para>When users or cloud services automatically assign CIDR blocks to elastic network interfaces (ENIs), the CIDR blocks must be allocated from the reserved CIDR block. If all addresses in the reserved CIDR block are allocated, the system returns an error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>prefix</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationType")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the reserved CIDR block for a vSwitch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-25navfgbue4g****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
