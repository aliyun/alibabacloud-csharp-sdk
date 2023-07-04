// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        /// <summary>
        /// The ID of the authorized CEN instance.
        /// </summary>
        [NameInMap("CenGrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesToCenResponseBodyCenGrantRules CenGrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyCenGrantRules : TeaModel {
            [NameInMap("CbnGrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesToCenResponseBodyCenGrantRulesCbnGrantRule> CbnGrantRule { get; set; }
            public class DescribeGrantRulesToCenResponseBodyCenGrantRulesCbnGrantRule : TeaModel {
                /// <summary>
                /// The UID of the Alibaba Cloud account to which the authorized CEN instance belongs.
                /// </summary>
                [NameInMap("CenInstanceId")]
                [Validation(Required=false)]
                public string CenInstanceId { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the authorization.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
