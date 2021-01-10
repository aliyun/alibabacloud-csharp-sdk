// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetHasUserinfoResponseBody : TeaModel {
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
        public GetHasUserinfoResponseBodyResultContent ResultContent { get; set; }
        public class GetHasUserinfoResponseBodyResultContent : TeaModel {
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
            public GetHasUserinfoResponseBodyResultContentData Data { get; set; }
            public class GetHasUserinfoResponseBodyResultContentData : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                [NameInMap("LastLoginTime")]
                [Validation(Required=false)]
                public long? LastLoginTime { get; set; }

                [NameInMap("RecentOperationTime")]
                [Validation(Required=false)]
                public long? RecentOperationTime { get; set; }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public GetHasUserinfoResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class GetHasUserinfoResponseBodyResultContentTopErrorCode : TeaModel {
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
            public GetHasUserinfoResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class GetHasUserinfoResponseBodyResultContentTopErrorReason : TeaModel {
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
