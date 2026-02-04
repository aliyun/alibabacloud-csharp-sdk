// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListFullNatEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the FULLNAT entries that are queried.</para>
        /// </summary>
        [NameInMap("FullNatEntries")]
        [Validation(Required=false)]
        public List<ListFullNatEntriesResponseBodyFullNatEntries> FullNatEntries { get; set; }
        public class ListFullNatEntriesResponseBodyFullNatEntries : TeaModel {
            [NameInMap("AccessDomain")]
            [Validation(Required=false)]
            public string AccessDomain { get; set; }

            /// <summary>
            /// <para>The backend IP address that is used for FULLNAT address translation in FULLNAT entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// <para>The backend port that is used for port mapping in FULLNAT entries. Valid values: <b>1</b> to <b>65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AccessPort")]
            [Validation(Required=false)]
            public string AccessPort { get; set; }

            /// <summary>
            /// <para>The time when the FULLNAT entry was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-27T02:44:40Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DomainResolve")]
            [Validation(Required=false)]
            public string DomainResolve { get; set; }

            /// <summary>
            /// <para>The description of the FULLNAT entry.</para>
            /// <para>The name must be 2 to 128 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("FullNatEntryDescription")]
            [Validation(Required=false)]
            public string FullNatEntryDescription { get; set; }

            /// <summary>
            /// <para>The ID of the FULLNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fullnat-gw8fz23jezpbblf1j****</para>
            /// </summary>
            [NameInMap("FullNatEntryId")]
            [Validation(Required=false)]
            public string FullNatEntryId { get; set; }

            /// <summary>
            /// <para>The name of the FULLNAT entry.</para>
            /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("FullNatEntryName")]
            [Validation(Required=false)]
            public string FullNatEntryName { get; set; }

            /// <summary>
            /// <para>The status of the FULLNAT entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("FullNatEntryStatus")]
            [Validation(Required=false)]
            public string FullNatEntryStatus { get; set; }

            /// <summary>
            /// <para>The ID of the FULLNAT table to which the FULLNAT entry belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fulltb-gw88z7hhlv43rmb26****</para>
            /// </summary>
            [NameInMap("FullNatTableId")]
            [Validation(Required=false)]
            public string FullNatTableId { get; set; }

            /// <summary>
            /// <para>The protocol of the packets that are forwarded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>UDP</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The NAT IP address that is used for address translation in FULLNAT entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// <para>The frontend port that is used for port mapping in FULLNAT entries. Valid values: <b>1</b> to <b>65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("NatIpPort")]
            [Validation(Required=false)]
            public string NatIpPort { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-gw80wedm8pq0tpr2****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The type of the ENI. The value is set to <b>Endpoint</b>, which indicates a reverse endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Endpoint</para>
            /// </summary>
            [NameInMap("NetworkInterfaceType")]
            [Validation(Required=false)]
            public string NetworkInterfaceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the FULLNAT table to which the queried FULLNAT entries belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullnat-gw8fz23jezpbblf1j****</para>
        /// </summary>
        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the VPC NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-gw8054kn57y3hq3bv****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>Indicates whether the token for the next query exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the value of <b>NextToken</b> is empty, no next queries are sent.</description></item>
        /// <item><description>If the value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F03E41F6-1A74-311F-8D98-124EEE9F37B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of FULLNAT entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
