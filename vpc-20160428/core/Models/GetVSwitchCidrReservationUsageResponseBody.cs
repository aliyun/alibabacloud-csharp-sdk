// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVSwitchCidrReservationUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of reserved CIDR blocks that are in use.</para>
        /// </summary>
        [NameInMap("CidrReservationUsages")]
        [Validation(Required=false)]
        public List<GetVSwitchCidrReservationUsageResponseBodyCidrReservationUsages> CidrReservationUsages { get; set; }
        public class GetVSwitchCidrReservationUsageResponseBodyCidrReservationUsages : TeaModel {
            /// <summary>
            /// <para>The CIDR block allocated to the ENI from the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.64/28</para>
            /// </summary>
            [NameInMap("IpPrefixCidr")]
            [Validation(Required=false)]
            public string IpPrefixCidr { get; set; }

            /// <summary>
            /// <para>The ID of the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcr-bp1m12saqteraw3rp****</para>
            /// </summary>
            [NameInMap("IpPrefixId")]
            [Validation(Required=false)]
            public string IpPrefixId { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI) whose CIDR block is allocated from the reserved CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp14v2sdd3v8htln****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the resource to which a CIDR block is allocated from the reserved CIDR block. Only <b>NetworkInterface</b> may be returned, which indicates an ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NetworkInterface</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

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
            /// <para>The ID of the vSwitch to which the reserved CIDR block belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-25navfgbue4g****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

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

    }

}
