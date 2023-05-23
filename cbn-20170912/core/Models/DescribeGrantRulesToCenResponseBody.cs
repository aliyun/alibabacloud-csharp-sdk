// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        /// <summary>
        /// The permissions that are granted to the CEN instance.
        /// </summary>
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesToCenResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule : TeaModel {
                /// <summary>
                /// The CEN instance ID.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the CEN instance belongs.
                /// </summary>
                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                /// <summary>
                /// The network instance ID.
                /// </summary>
                [NameInMap("ChildInstanceId")]
                [Validation(Required=false)]
                public string ChildInstanceId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the network instance belongs.
                /// </summary>
                [NameInMap("ChildInstanceOwnerId")]
                [Validation(Required=false)]
                public long? ChildInstanceOwnerId { get; set; }

                /// <summary>
                /// The region ID of the network instance.
                /// </summary>
                [NameInMap("ChildInstanceRegionId")]
                [Validation(Required=false)]
                public string ChildInstanceRegionId { get; set; }

                /// <summary>
                /// The type of the network instance. Valid values:
                /// 
                /// *   **VPC**
                /// *   **VBR**
                /// *   **CCN**
                /// *   **VPN**
                /// </summary>
                [NameInMap("ChildInstanceType")]
                [Validation(Required=false)]
                public string ChildInstanceType { get; set; }

                /// <summary>
                /// The entity that pays the fees of the network instance. Valid values:
                /// 
                /// *   **PayByCenOwner**: the Alibaba Cloud account that owns the CEN instance.
                /// *   **PayByResourceOwner**: the Alibaba Cloud account that owns the network instance.
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value of **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
