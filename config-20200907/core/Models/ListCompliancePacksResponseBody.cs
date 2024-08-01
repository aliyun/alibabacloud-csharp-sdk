// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePacksResponseBody : TeaModel {
        /// <summary>
        /// The compliance packages returned.
        /// </summary>
        [NameInMap("CompliancePacksResult")]
        [Validation(Required=false)]
        public ListCompliancePacksResponseBodyCompliancePacksResult CompliancePacksResult { get; set; }
        public class ListCompliancePacksResponseBodyCompliancePacksResult : TeaModel {
            /// <summary>
            /// The compliance packages.
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<ListCompliancePacksResponseBodyCompliancePacksResultCompliancePacks> CompliancePacks { get; set; }
            public class ListCompliancePacksResponseBodyCompliancePacksResultCompliancePacks : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the compliance package belongs.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The compliance package ID.
                /// </summary>
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                /// <summary>
                /// The name of the compliance package.
                /// </summary>
                [NameInMap("CompliancePackName")]
                [Validation(Required=false)]
                public string CompliancePackName { get; set; }

                /// <summary>
                /// The ID of the compliance package template.
                /// </summary>
                [NameInMap("CompliancePackTemplateId")]
                [Validation(Required=false)]
                public string CompliancePackTemplateId { get; set; }

                /// <summary>
                /// The timestamp when the compliance package was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The description of the compliance package.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The risk level of the resources that are not compliant with the rules in the compliance package. Valid values:
                /// 
                /// *   1: high
                /// *   2: medium
                /// *   3: low
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// The status of the compliance package. Valid values:
                /// 
                /// *   ACTIVE: The compliance package is normal.
                /// *   CREATING: The compliance package is being created.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of compliance packages returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
