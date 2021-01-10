// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListHasInspectRulestatusactionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListHasInspectRulestatusactionResponseBodyResultContent ResultContent { get; set; }
        public class ListHasInspectRulestatusactionResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListHasInspectRulestatusactionResponseBodyResultContentData> Data { get; set; }
            public class ListHasInspectRulestatusactionResponseBodyResultContentData : TeaModel {
                public List<ListHasInspectRulestatusactionResponseBodyResultContentDataAvailableActions> AvailableActions { get; set; }
                public class ListHasInspectRulestatusactionResponseBodyResultContentDataAvailableActions : TeaModel {
                    public string Code { get; set; }
                    public string Description { get; set; }
                }
                public ListHasInspectRulestatusactionResponseBodyResultContentDataStatus Status { get; set; }
                public class ListHasInspectRulestatusactionResponseBodyResultContentDataStatus : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public ListHasInspectRulestatusactionResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class ListHasInspectRulestatusactionResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public ListHasInspectRulestatusactionResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class ListHasInspectRulestatusactionResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
