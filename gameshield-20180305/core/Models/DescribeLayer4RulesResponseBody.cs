// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeLayer4RulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public DescribeLayer4RulesResponseBodyExtInfo ExtInfo { get; set; }
        public class DescribeLayer4RulesResponseBodyExtInfo : TeaModel {
            [NameInMap("UseCc")]
            [Validation(Required=false)]
            public int? UseCc { get; set; }
            [NameInMap("NgRouteEnable")]
            [Validation(Required=false)]
            public int? NgRouteEnable { get; set; }
        };

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("L4RuleList")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulesResponseBodyL4RuleList> L4RuleList { get; set; }
        public class DescribeLayer4RulesResponseBodyL4RuleList : TeaModel {
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("BackPort")]
            [Validation(Required=false)]
            public int? BackPort { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public long? BizId { get; set; }

            [NameInMap("Rservers")]
            [Validation(Required=false)]
            public List<string> Rservers { get; set; }

            [NameInMap("LvsPolicy")]
            [Validation(Required=false)]
            public string LvsPolicy { get; set; }

            [NameInMap("FrontPort")]
            [Validation(Required=false)]
            public int? FrontPort { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
