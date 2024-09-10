// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarSubscribedStrategyResponseBody : TeaModel {
        /// <summary>
        /// The page number. Pages start from page 1.
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
        /// The policies.
        /// </summary>
        [NameInMap("SoarStrategies")]
        [Validation(Required=false)]
        public List<DescribeSoarSubscribedStrategyResponseBodySoarStrategies> SoarStrategies { get; set; }
        public class DescribeSoarSubscribedStrategyResponseBodySoarStrategies : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account ID of the creator.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The description of the policy.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The total number of times that the policy is executed.
            /// </summary>
            [NameInMap("ExecuteNum")]
            [Validation(Required=false)]
            public string ExecuteNum { get; set; }

            /// <summary>
            /// The timestamp when the policy was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The timestamp when the policy was modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The ID of the policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The execution mode. Valid values:
            /// 
            /// *   runmode_TRIGGER_BY_USER: manually executed
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// The type of the policy. Valid values:
            /// 
            /// *   type_vulfix: vulnerability operations
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
