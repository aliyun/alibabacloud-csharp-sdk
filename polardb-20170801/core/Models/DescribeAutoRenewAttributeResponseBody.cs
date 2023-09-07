// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// The renewal information about the clusters.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAutoRenewAttributeResponseBodyItems Items { get; set; }
        public class DescribeAutoRenewAttributeResponseBodyItems : TeaModel {
            [NameInMap("AutoRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute> AutoRenewAttribute { get; set; }
            public class DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute : TeaModel {
                /// <summary>
                /// Indicates whether the auto-renewal feature is enabled. Valid values:
                /// 
                /// *   true: enabled
                /// *   false: disabled
                /// </summary>
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The renewal duration.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The unit of the duration. Valid values:
                /// 
                /// *   Year
                /// *   Month
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The renewal status. Valid values:
                /// 
                /// *   AutoRenewal: The cluster is automatically renewed.
                /// *   Normal: The cluster is manually renewed. The system sends a text message to remind you before the cluster expires.
                /// *   NotRenewal: The cluster is not renewed. The system does not send a reminder for expiration but only sends a text message three days before the cluster expires to remind you that the cluster is not renewed.
                /// </summary>
                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        /// <summary>
        /// The page number of the page returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
