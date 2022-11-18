// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeGrantSagVbrRulesResponseBody : TeaModel {
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantSagVbrRulesResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantSagVbrRulesResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantSagVbrRulesResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantSagVbrRulesResponseBodyGrantRulesGrantRule : TeaModel {
                [NameInMap("Bound")]
                [Validation(Required=false)]
                public bool? Bound { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

                [NameInMap("SmartAGUid")]
                [Validation(Required=false)]
                public long? SmartAGUid { get; set; }

                [NameInMap("VbrInstanceId")]
                [Validation(Required=false)]
                public string VbrInstanceId { get; set; }

                [NameInMap("VbrRegionId")]
                [Validation(Required=false)]
                public string VbrRegionId { get; set; }

                [NameInMap("VbrUid")]
                [Validation(Required=false)]
                public long? VbrUid { get; set; }

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
