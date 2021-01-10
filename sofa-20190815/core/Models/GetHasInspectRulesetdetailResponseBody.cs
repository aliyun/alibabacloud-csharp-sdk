// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetHasInspectRulesetdetailResponseBody : TeaModel {
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
        public GetHasInspectRulesetdetailResponseBodyResultContent ResultContent { get; set; }
        public class GetHasInspectRulesetdetailResponseBodyResultContent : TeaModel {
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
            public GetHasInspectRulesetdetailResponseBodyResultContentData Data { get; set; }
            public class GetHasInspectRulesetdetailResponseBodyResultContentData : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RuleSetType")]
                [Validation(Required=false)]
                public string RuleSetType { get; set; }

                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetHasInspectRulesetdetailResponseBodyResultContentDataTags> Tags { get; set; }
                public class GetHasInspectRulesetdetailResponseBodyResultContentDataTags : TeaModel {
                    [NameInMap("TagCode")]
                    [Validation(Required=false)]
                    public string TagCode { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public GetHasInspectRulesetdetailResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class GetHasInspectRulesetdetailResponseBodyResultContentTopErrorCode : TeaModel {
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
            public GetHasInspectRulesetdetailResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class GetHasInspectRulesetdetailResponseBodyResultContentTopErrorReason : TeaModel {
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
