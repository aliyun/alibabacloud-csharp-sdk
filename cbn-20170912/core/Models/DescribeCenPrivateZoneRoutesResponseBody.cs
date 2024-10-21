// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenPrivateZoneRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jmc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IP address of the DNS server used by PrivateZone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.100.XX.XX/32,100.100.XX.XX/32</para>
        /// </summary>
        [NameInMap("PrivateZoneDnsServers")]
        [Validation(Required=false)]
        public string PrivateZoneDnsServers { get; set; }

        /// <summary>
        /// <para>The detailed configuration of PrivateZone.</para>
        /// </summary>
        [NameInMap("PrivateZoneInfos")]
        [Validation(Required=false)]
        public DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfos PrivateZoneInfos { get; set; }
        public class DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfos : TeaModel {
            [NameInMap("PrivateZoneInfo")]
            [Validation(Required=false)]
            public List<DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfosPrivateZoneInfo> PrivateZoneInfo { get; set; }
            public class DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfosPrivateZoneInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the region where PrivateZone is accessed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("AccessRegionId")]
                [Validation(Required=false)]
                public string AccessRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the region where PrivateZone is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("HostRegionId")]
                [Validation(Required=false)]
                public string HostRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC that is associated with PrivateZone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp18sth14qii3pnvo****</para>
                /// </summary>
                [NameInMap("HostVpcId")]
                [Validation(Required=false)]
                public string HostVpcId { get; set; }

                /// <summary>
                /// <para>The status of PrivateZone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b>: being created</description></item>
                /// <item><description><b>Active</b>: available</description></item>
                /// <item><description><b>Deleting</b>: being deleted</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>461EC1B5-04A8-4706-8764-8F5BCEF48A6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
