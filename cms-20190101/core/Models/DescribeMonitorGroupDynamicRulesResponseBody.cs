// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupDynamicRulesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMonitorGroupDynamicRulesResponseBodyResource Resource { get; set; }
        public class DescribeMonitorGroupDynamicRulesResponseBodyResource : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResource> Resource { get; set; }
            public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResource : TeaModel {
                public string FilterRelation { get; set; }
                public DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters Filters { get; set; }
                public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters : TeaModel {
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter> Filter { get; set; }
                    public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public string Category { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
