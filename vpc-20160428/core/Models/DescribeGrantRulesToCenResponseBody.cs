// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        [NameInMap("CenGrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesToCenResponseBodyCenGrantRules CenGrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyCenGrantRules : TeaModel {
            [NameInMap("CbnGrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesToCenResponseBodyCenGrantRulesCbnGrantRule> CbnGrantRule { get; set; }
            public class DescribeGrantRulesToCenResponseBodyCenGrantRulesCbnGrantRule : TeaModel {
                [NameInMap("CenInstanceId")]
                [Validation(Required=false)]
                public string CenInstanceId { get; set; }

                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
