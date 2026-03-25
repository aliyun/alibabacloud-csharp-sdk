// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCensResponseBody : TeaModel {
        [NameInMap("Cens")]
        [Validation(Required=false)]
        public DescribeCensResponseBodyCens Cens { get; set; }
        public class DescribeCensResponseBodyCens : TeaModel {
            [NameInMap("Cen")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensCen> Cen { get; set; }
            public class DescribeCensResponseBodyCensCen : TeaModel {
                [NameInMap("CenBandwidthPackageIds")]
                [Validation(Required=false)]
                public DescribeCensResponseBodyCensCenCenBandwidthPackageIds CenBandwidthPackageIds { get; set; }
                public class DescribeCensResponseBodyCensCenCenBandwidthPackageIds : TeaModel {
                    [NameInMap("CenBandwidthPackageId")]
                    [Validation(Required=false)]
                    public List<string> CenBandwidthPackageId { get; set; }

                }

                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Ipv6Level")]
                [Validation(Required=false)]
                public string Ipv6Level { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProtectionLevel")]
                [Validation(Required=false)]
                public string ProtectionLevel { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCensResponseBodyCensCenTags Tags { get; set; }
                public class DescribeCensResponseBodyCensCenTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCensResponseBodyCensCenTagsTag> Tag { get; set; }
                    public class DescribeCensResponseBodyCensCenTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

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
