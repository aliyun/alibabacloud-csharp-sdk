// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityRuleTagListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityRuleTagListResponseBodyData> Data { get; set; }
        public class GetQualityRuleTagListResponseBodyData : TeaModel {
            [NameInMap("RuleTagId")]
            [Validation(Required=false)]
            public long? RuleTagId { get; set; }

            [NameInMap("RuleTagName")]
            [Validation(Required=false)]
            public string RuleTagName { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
