// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeGrantSagVbrRulesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantSagVbrRulesResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantSagVbrRulesResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantSagVbrRulesResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantSagVbrRulesResponseBodyGrantRulesGrantRule : TeaModel {
                public string VbrInstanceId { get; set; }
                public long? VbrUid { get; set; }
                public string VbrRegionId { get; set; }
                public long? CreateTime { get; set; }
                public string SmartAGId { get; set; }
                public bool? Bound { get; set; }
                public string InstanceId { get; set; }
                public long? SmartAGUid { get; set; }
            }
        };

    }

}
