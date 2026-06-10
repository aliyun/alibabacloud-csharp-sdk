// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserProfilePathRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserProfilePathRule")]
        [Validation(Required=false)]
        public DescribeUserProfilePathRulesResponseBodyUserProfilePathRule UserProfilePathRule { get; set; }
        public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRule : TeaModel {
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRules> Rules { get; set; }
            public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRules : TeaModel {
                [NameInMap("BlackPath")]
                [Validation(Required=false)]
                public DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesBlackPath BlackPath { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesBlackPath : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("WhitePaths")]
                [Validation(Required=false)]
                public List<DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesWhitePaths> WhitePaths { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesWhitePaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("UserProfileRuleType")]
            [Validation(Required=false)]
            public string UserProfileRuleType { get; set; }

        }

    }

}
