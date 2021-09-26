// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRuleCategoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<DescribeRuleCategoryResponseBodyRuleList> RuleList { get; set; }
        public class DescribeRuleCategoryResponseBodyRuleList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("ChildList")]
            [Validation(Required=false)]
            public List<DescribeRuleCategoryResponseBodyRuleListChildList> ChildList { get; set; }
            public class DescribeRuleCategoryResponseBodyRuleListChildList : TeaModel {
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        [NameInMap("ProductList")]
        [Validation(Required=false)]
        public List<DescribeRuleCategoryResponseBodyProductList> ProductList { get; set; }
        public class DescribeRuleCategoryResponseBodyProductList : TeaModel {
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
