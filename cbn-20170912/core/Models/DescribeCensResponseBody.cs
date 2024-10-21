// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCensResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the CEN instance.</para>
        /// </summary>
        [NameInMap("Cens")]
        [Validation(Required=false)]
        public DescribeCensResponseBodyCens Cens { get; set; }
        public class DescribeCensResponseBodyCens : TeaModel {
            [NameInMap("Cen")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensCen> Cen { get; set; }
            public class DescribeCensResponseBodyCensCen : TeaModel {
                /// <summary>
                /// <para>The IDs of the bandwidth plans that are associated with the CEN instance.</para>
                /// </summary>
                [NameInMap("CenBandwidthPackageIds")]
                [Validation(Required=false)]
                public DescribeCensResponseBodyCensCenCenBandwidthPackageIds CenBandwidthPackageIds { get; set; }
                public class DescribeCensResponseBodyCensCenCenBandwidthPackageIds : TeaModel {
                    [NameInMap("CenBandwidthPackageId")]
                    [Validation(Required=false)]
                    public List<string> CenBandwidthPackageId { get; set; }

                }

                /// <summary>
                /// <para>The CEN instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-0xyeagctz5sfg9****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The time when the CEN instance was created.</para>
                /// <para>The time follows the ISO8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-22T07:44Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desctest</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 is enabled for the CEN instance.</para>
                /// <list type="bullet">
                /// <item><description><b>ENABLE</b></description></item>
                /// <item><description><b>DISABLED</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DISABLED</para>
                /// </summary>
                [NameInMap("Ipv6Level")]
                [Validation(Required=false)]
                public string Ipv6Level { get; set; }

                /// <summary>
                /// <para>The CEN instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nametest</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The level of CIDR block overlapping.</para>
                /// <para><b>REDUCED</b>: Overlapped CIDR blocks are allowed. This value specifies that CIDR blocks can overlap but CIDR blocks cannot be duplicates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REDUCED</para>
                /// </summary>
                [NameInMap("ProtectionLevel")]
                [Validation(Required=false)]
                public string ProtectionLevel { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the CEN instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfm3unpnuw****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of the CEN instance.</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Active</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The IDs of the tags that are added to the CEN instance.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCensResponseBodyCensCenTags Tags { get; set; }
                public class DescribeCensResponseBodyCensCenTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCensResponseBodyCensCenTagsTag> Tag { get; set; }
                    public class DescribeCensResponseBodyCensCenTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagtest</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagtest</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The number of the page returned.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BFA6822-240E-4E27-B4C8-AA400EF7474D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
