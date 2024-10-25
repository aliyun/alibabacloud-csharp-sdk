// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecondaryPublicIpAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of returned secondary IP addresses.</para>
        /// </summary>
        [NameInMap("SecondaryPublicIpAddresses")]
        [Validation(Required=false)]
        public List<DescribeSecondaryPublicIpAddressesResponseBodySecondaryPublicIpAddresses> SecondaryPublicIpAddresses { get; set; }
        public class DescribeSecondaryPublicIpAddressesResponseBodySecondaryPublicIpAddresses : TeaModel {
            /// <summary>
            /// <para>The subnet mask of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("CidrMask")]
            [Validation(Required=false)]
            public int? CidrMask { get; set; }

            /// <summary>
            /// <para>The time when the secondary public IP address was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T09:43:49Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the edge node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-15</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.XXX.XXX.1</para>
            /// </summary>
            [NameInMap("Gateway")]
            [Validation(Required=false)]
            public string Gateway { get; set; }

            /// <summary>
            /// <para>The version of the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ipv4</b></description></item>
            /// <item><description><b>ipv6</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The Internet service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cmcc: China Mobile.</description></item>
            /// <item><description>unicom: China Unicom.</description></item>
            /// <item><description>telecom: China Telecom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>telecom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The secondary public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.XXX.XXX.4</para>
            /// </summary>
            [NameInMap("SecondaryPublicIpAddress")]
            [Validation(Required=false)]
            public string SecondaryPublicIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the secondary public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spi-5wys0pio93c9f9ukzj2f2fwyr</para>
            /// </summary>
            [NameInMap("SecondaryPublicIpId")]
            [Validation(Required=false)]
            public string SecondaryPublicIpId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
