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
            /// The IPv6 level.
            /// 
            /// >  IPv6 is not supported.
            /// 
            /// Valid value:
            /// 
            /// *   DISABLED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
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
            /// The bandwidth plans that are bound to the CEN instance.
            /// </summary>
            [NameInMap("PackageIds")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensPackageIds> PackageIds { get; set; }
            public class DescribeCensResponseBodyCensPackageIds : TeaModel {
                /// <summary>
                /// The ID of the bandwidth plan that is bound to the CEN instance.
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

            }

            /// <summary>
            /// The tolerated level of CIDR block conflict.
            /// 
            /// Valid value:
            /// 
            /// *   REDUCED: CIDR block conflicts are allowed, but the conflicting CIDR blocks cannot be identical.
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            /// <summary>
            /// The status of the CEN instance.
            /// 
            /// Valid values:
            /// 
            /// *   Creating
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Active
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Deleting
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
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
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
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
