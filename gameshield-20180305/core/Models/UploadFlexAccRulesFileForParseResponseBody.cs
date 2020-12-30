// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class UploadFlexAccRulesFileForParseResponseBody : TeaModel {
        [NameInMap("FlexAccFwdRules")]
        [Validation(Required=false)]
        public List<UploadFlexAccRulesFileForParseResponseBodyFlexAccFwdRules> FlexAccFwdRules { get; set; }
        public class UploadFlexAccRulesFileForParseResponseBodyFlexAccFwdRules : TeaModel {
            [NameInMap("MasterIpList")]
            [Validation(Required=false)]
            public string MasterIpList { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SlaveIpList")]
            [Validation(Required=false)]
            public string SlaveIpList { get; set; }

            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("AccType")]
            [Validation(Required=false)]
            public int? AccType { get; set; }

            [NameInMap("IpList")]
            [Validation(Required=false)]
            public string IpList { get; set; }

            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public string DomainList { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
