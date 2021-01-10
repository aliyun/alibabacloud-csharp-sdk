// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateHasBaselineNwapprovalprocessResponseBody : TeaModel {
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
        public CreateHasBaselineNwapprovalprocessResponseBodyResultContent ResultContent { get; set; }
        public class CreateHasBaselineNwapprovalprocessResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public CreateHasBaselineNwapprovalprocessResponseBodyResultContentData Data { get; set; }
            public class CreateHasBaselineNwapprovalprocessResponseBodyResultContentData : TeaModel {
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

                [NameInMap("ApprovalNodes")]
                [Validation(Required=false)]
                public string ApprovalNodes { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("ApprovalType")]
                [Validation(Required=false)]
                public string ApprovalType { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("DefaultProcess")]
                [Validation(Required=false)]
                public bool? DefaultProcess { get; set; }

                [NameInMap("NwApprovalSummitters")]
                [Validation(Required=false)]
                public List<CreateHasBaselineNwapprovalprocessResponseBodyResultContentDataNwApprovalSummitters> NwApprovalSummitters { get; set; }
                public class CreateHasBaselineNwapprovalprocessResponseBodyResultContentDataNwApprovalSummitters : TeaModel {
                    [NameInMap("ProcessId")]
                    [Validation(Required=false)]
                    public string ProcessId { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public string UtcModified { get; set; }

                    [NameInMap("UtcCreate")]
                    [Validation(Required=false)]
                    public string UtcCreate { get; set; }

                    [NameInMap("ApprovalType")]
                    [Validation(Required=false)]
                    public string ApprovalType { get; set; }

                    [NameInMap("Nickname")]
                    [Validation(Required=false)]
                    public string Nickname { get; set; }

                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

            }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public CreateHasBaselineNwapprovalprocessResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class CreateHasBaselineNwapprovalprocessResponseBodyResultContentTopErrorCode : TeaModel {
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
            public CreateHasBaselineNwapprovalprocessResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class CreateHasBaselineNwapprovalprocessResponseBodyResultContentTopErrorReason : TeaModel {
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
