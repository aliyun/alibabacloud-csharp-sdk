// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDefaultRulesResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDefaultRulesResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafDefaultRulesResponseBodyContent : TeaModel {
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafDefaultRulesResponseBodyContentRules> Rules { get; set; }
            public class DescribeDcdnWafDefaultRulesResponseBodyContentRules : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
