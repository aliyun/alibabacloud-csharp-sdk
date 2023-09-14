// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotasRequest : TeaModel {
        /// <summary>
        /// The quota dimensions.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ListProductQuotasRequestDimensions> Dimensions { get; set; }
        public class ListProductQuotasRequestDimensions : TeaModel {
            /// <summary>
            /// The key of the dimension.
            /// 
            /// > The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the dimension.
            /// 
            /// > The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The code of the dimension group.
        /// </summary>
        [NameInMap("GroupCode")]
        [Validation(Required=false)]
        public string GroupCode { get; set; }

        /// <summary>
        /// The keyword that you want to use to search for the quotas.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The maximum number of records that can be returned for the query.
        /// 
        /// Valid values: 1 to 100. Default value: 30.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position from which you want to start the query. If you leave this parameter empty, the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// 
        /// > For more information, see [Alibaba Cloud services that support Quota Center](~~182368~~).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the quota.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// The type of the quota. Valid values:
        /// 
        /// *   CommonQuota (default value): general quota
        /// *   FlowControl: API rate limit
        /// *   WhiteListLabel: whitelist quota
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// The field based on which you want to sort the returned records. This parameter is available only for quotas that belong to ECS Quotas by Instance Type. Valid values:
        /// 
        /// *   TIME: The returned records are sorted by the last update time.
        /// *   TOTAL: The returned records are sorted by the usage of the total quota.
        /// *   RESERVED: The returned records are sorted by the usage of the reserved quota.
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// The order in which you want to sort the returned records. This parameter is available only for quotas that belong to ECS Quotas by Instance Type. Valid values:
        /// 
        /// *   Ascending: ascending order
        /// *   Descending: descending order
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
