// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetUserProfilePathRulesRequest : TeaModel {
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("UserProfilePathRule")]
        [Validation(Required=false)]
        public List<SetUserProfilePathRulesRequestUserProfilePathRule> UserProfilePathRule { get; set; }
        public class SetUserProfilePathRulesRequestUserProfilePathRule : TeaModel {
            [NameInMap("BlackPath")]
            [Validation(Required=false)]
            public SetUserProfilePathRulesRequestUserProfilePathRuleBlackPath BlackPath { get; set; }
            public class SetUserProfilePathRulesRequestUserProfilePathRuleBlackPath : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("WhitePaths")]
            [Validation(Required=false)]
            public List<SetUserProfilePathRulesRequestUserProfilePathRuleWhitePaths> WhitePaths { get; set; }
            public class SetUserProfilePathRulesRequestUserProfilePathRuleWhitePaths : TeaModel {
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
