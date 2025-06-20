// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class ChangeCheckResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChangeCheckResponseBodyData Data { get; set; }
        public class ChangeCheckResponseBodyData : TeaModel {
            [NameInMap("ApproveResultUrl")]
            [Validation(Required=false)]
            public string ApproveResultUrl { get; set; }

            [NameInMap("BgCheckStatus")]
            [Validation(Required=false)]
            public string BgCheckStatus { get; set; }

            [NameInMap("BgVid")]
            [Validation(Required=false)]
            public string BgVid { get; set; }

            [NameInMap("ChangeStatus")]
            [Validation(Required=false)]
            public string ChangeStatus { get; set; }

            [NameInMap("CheckResultUrl")]
            [Validation(Required=false)]
            public string CheckResultUrl { get; set; }

            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            [NameInMap("CheckholdReason")]
            [Validation(Required=false)]
            public List<string> CheckholdReason { get; set; }

            [NameInMap("RuleDetailUrlList")]
            [Validation(Required=false)]
            public List<ChangeCheckResponseBodyDataRuleDetailUrlList> RuleDetailUrlList { get; set; }
            public class ChangeCheckResponseBodyDataRuleDetailUrlList : TeaModel {
                [NameInMap("SceneEnum")]
                [Validation(Required=false)]
                public string SceneEnum { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("SourceOrderId")]
            [Validation(Required=false)]
            public string SourceOrderId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
