// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsRequest : TeaModel {
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsRequestDimensions> Dimensions { get; set; }
        public class ListQuotaApplicationsRequestDimensions : TeaModel {
            /// <summary>
            /// The dimension keys.
            /// 
            /// >  The value range of N varies based on the number of dimensions that are supported by the related cloud service.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The dimension values.
            /// 
            /// >  The value range of N varies based on the number of dimensions that are supported by the related cloud service.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The keyword that you want to use to search for the application.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The maximum number of records that you want to return for the query.
        /// 
        /// Valid values: 1 to 200. Default value: 30.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position from which you want to start the query. An empty value indicates that the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The abbreviation of the cloud service name.
        /// 
        /// >  For more information, see [Alibaba Cloud services that support Quota Center](~~182368~~).
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
        /// *   FlowControl: API rate limit
        /// *   CommonQuota: general quota
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// The status of the application. Valid values:
        /// 
        /// *   Disagree: The application is rejected.
        /// *   Agree: The application is approved.
        /// *   Process: The application is pending approval.
        /// *   Cancel: The application is closed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
