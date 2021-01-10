// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateHasInspectRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public CreateHasInspectRuleResponseBodyResultContent ResultContent { get; set; }
        public class CreateHasInspectRuleResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public CreateHasInspectRuleResponseBodyResultContentData Data { get; set; }
            public class CreateHasInspectRuleResponseBodyResultContentData : TeaModel {
                [NameInMap("RuleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("Args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<CreateHasInspectRuleResponseBodyResultContentDataTags> Tags { get; set; }
                public class CreateHasInspectRuleResponseBodyResultContentDataTags : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("TagCode")]
                    [Validation(Required=false)]
                    public string TagCode { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("MaintainTeam")]
                [Validation(Required=false)]
                public CreateHasInspectRuleResponseBodyResultContentDataMaintainTeam MaintainTeam { get; set; }
                public class CreateHasInspectRuleResponseBodyResultContentDataMaintainTeam : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("TagCode")]
                    [Validation(Required=false)]
                    public string TagCode { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                };

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("FixMethod")]
                [Validation(Required=false)]
                public string FixMethod { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public CreateHasInspectRuleResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class CreateHasInspectRuleResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

            }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public CreateHasInspectRuleResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class CreateHasInspectRuleResponseBodyResultContentTopErrorReason : TeaModel {
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
