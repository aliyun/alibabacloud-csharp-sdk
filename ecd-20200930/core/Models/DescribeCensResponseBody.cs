// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCensResponseBody : TeaModel {
        /// <summary>
        /// Details of the CEN instances.
        /// </summary>
        [NameInMap("Cens")]
        [Validation(Required=false)]
        public List<DescribeCensResponseBodyCens> Cens { get; set; }
        public class DescribeCensResponseBodyCens : TeaModel {
            /// <summary>
            /// The ID of the CEN instance.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The time when the CEN instance was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the CEN instance.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether IPv6 is supported. A value of DISABLED indicates that IPv6 is not supported.
            /// 
            /// **
            /// 
            /// **Description** IPv6 is not supported.
            /// </summary>
            [NameInMap("Ipv6Level")]
            [Validation(Required=false)]
            public string Ipv6Level { get; set; }

            /// <summary>
            /// The name of the CEN instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The IDs of the bandwidth plans that are associated with the CEN instance.
            /// </summary>
            [NameInMap("PackageIds")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensPackageIds> PackageIds { get; set; }
            public class DescribeCensResponseBodyCensPackageIds : TeaModel {
                /// <summary>
                /// The ID of the bandwidth plan that is associated with the CEN instance.
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

            }

            /// <summary>
            /// The level of CIDR block overlapping. If REDUCED returns, the CIDR blocks can overlap with each other but must not be the same.
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            /// <summary>
            /// The status of the CEN instance. Valid values:
            /// 
            /// *   Creating
            /// *   Active
            /// *   Deleting
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the CEN instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensTags> Tags { get; set; }
            public class DescribeCensResponseBodyCensTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of CEN instances returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
