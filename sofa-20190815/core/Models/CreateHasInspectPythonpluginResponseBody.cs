// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateHasInspectPythonpluginResponseBody : TeaModel {
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
        public CreateHasInspectPythonpluginResponseBodyResultContent ResultContent { get; set; }
        public class CreateHasInspectPythonpluginResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public CreateHasInspectPythonpluginResponseBodyResultContentData Data { get; set; }
            public class CreateHasInspectPythonpluginResponseBodyResultContentData : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Gid")]
                [Validation(Required=false)]
                public string Gid { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("DeleteStatus")]
                [Validation(Required=false)]
                public long? DeleteStatus { get; set; }

                [NameInMap("AvailableActions")]
                [Validation(Required=false)]
                public List<CreateHasInspectPythonpluginResponseBodyResultContentDataAvailableActions> AvailableActions { get; set; }
                public class CreateHasInspectPythonpluginResponseBodyResultContentDataAvailableActions : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DeleteAt")]
                [Validation(Required=false)]
                public string DeleteAt { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

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
            public CreateHasInspectPythonpluginResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class CreateHasInspectPythonpluginResponseBodyResultContentTopErrorCode : TeaModel {
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
            public CreateHasInspectPythonpluginResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class CreateHasInspectPythonpluginResponseBodyResultContentTopErrorReason : TeaModel {
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
