// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVSwitchCidrReservationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of reserved CIDR blocks.</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservations")]
        [Validation(Required=false)]
        public List<ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservations> VSwitchCidrReservations { get; set; }
        public class ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservations : TeaModel {
            /// <summary>
            /// <para>The number of used prefixes in the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AssignedCidrCount")]
            [Validation(Required=false)]
            public int? AssignedCidrCount { get; set; }

            /// <summary>
            /// <para>The number of available prefixes in the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AvailableCidrCount")]
            [Validation(Required=false)]
            public int? AvailableCidrCount { get; set; }

            /// <summary>
            /// <para>The time when the reserved CIDR block was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-14T10:02:37Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

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

            /// <summary>
            /// <para>The status of the reserved CIDR block. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Assigning</b></description></item>
            /// <item><description><b>Assigned</b></description></item>
            /// <item><description><b>Releasing</b></description></item>
            /// <item><description><b>Released</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Assigned</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservationsTags> Tags { get; set; }
            public class ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservationsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the reserved CIDR block. Valid value: <b>prefix</b>. CIDR blocks are allocated from the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prefix</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.64/28</para>
            /// </summary>
            [NameInMap("VSwitchCidrReservationCidr")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationCidr { get; set; }

            /// <summary>
            /// <para>The description of the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReservationDescription</para>
            /// </summary>
            [NameInMap("VSwitchCidrReservationDescription")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationDescription { get; set; }

            /// <summary>
            /// <para>The ID of the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcr-bp1m12saqteraw3rp****</para>
            /// </summary>
            [NameInMap("VSwitchCidrReservationId")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationId { get; set; }

            /// <summary>
            /// <para>The name of the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReservationName</para>
            /// </summary>
            [NameInMap("VSwitchCidrReservationName")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationName { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the reserved CIDR block belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-25navfgbue4g****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) to which the reserved CIDR block belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1wdz2pdhgurz1od****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
