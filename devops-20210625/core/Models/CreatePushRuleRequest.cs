// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreatePushRuleRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("ruleInfos")]
        [Validation(Required=false)]
        public List<CreatePushRuleRequestRuleInfos> RuleInfos { get; set; }
        public class CreatePushRuleRequestRuleInfos : TeaModel {
            [NameInMap("checkerName")]
            [Validation(Required=false)]
            public string CheckerName { get; set; }

            [NameInMap("checkerType")]
            [Validation(Required=false)]
            public string CheckerType { get; set; }

            [NameInMap("extraMessage")]
            [Validation(Required=false)]
            public string ExtraMessage { get; set; }

            [NameInMap("fileRuleRegexes")]
            [Validation(Required=false)]
            public List<string> FileRuleRegexes { get; set; }

        }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
