// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class SearchFlexFwdRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("FlexFwdRules")]
        [Validation(Required=false)]
        public List<SearchFlexFwdRulesResponseBodyFlexFwdRules> FlexFwdRules { get; set; }
        public class SearchFlexFwdRulesResponseBodyFlexFwdRules : TeaModel {
            [NameInMap("MasterIpList")]
            [Validation(Required=false)]
            public string MasterIpList { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SlaveIpList")]
            [Validation(Required=false)]
            public string SlaveIpList { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

        }

    }

}
