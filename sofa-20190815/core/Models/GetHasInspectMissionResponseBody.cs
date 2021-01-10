// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetHasInspectMissionResponseBody : TeaModel {
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
        public GetHasInspectMissionResponseBodyResultContent ResultContent { get; set; }
        public class GetHasInspectMissionResponseBodyResultContent : TeaModel {
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
            public GetHasInspectMissionResponseBodyResultContentData Data { get; set; }
            public class GetHasInspectMissionResponseBodyResultContentData : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("MissionType")]
                [Validation(Required=false)]
                public string MissionType { get; set; }

                [NameInMap("MissionMark")]
                [Validation(Required=false)]
                public string MissionMark { get; set; }

                [NameInMap("ExecutableStatus")]
                [Validation(Required=false)]
                public string ExecutableStatus { get; set; }

                [NameInMap("CurrentExecFlag")]
                [Validation(Required=false)]
                public long? CurrentExecFlag { get; set; }

                [NameInMap("DeleteStatus")]
                [Validation(Required=false)]
                public long? DeleteStatus { get; set; }

                [NameInMap("DeleteAt")]
                [Validation(Required=false)]
                public string DeleteAt { get; set; }

                [NameInMap("LastExecTime")]
                [Validation(Required=false)]
                public string LastExecTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public GetHasInspectMissionResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class GetHasInspectMissionResponseBodyResultContentTopErrorCode : TeaModel {
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
            public GetHasInspectMissionResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class GetHasInspectMissionResponseBodyResultContentTopErrorReason : TeaModel {
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
