// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetGWAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGWAppResponseBodyData Data { get; set; }
        public class GetGWAppResponseBodyData : TeaModel {
            [NameInMap("ApiCount")]
            [Validation(Required=false)]
            public long? ApiCount { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }
            [NameInMap("CanDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
            [NameInMap("AuthenticationConfig")]
            [Validation(Required=false)]
            public GetGWAppResponseBodyDataAuthenticationConfig AuthenticationConfig { get; set; }
            public class GetGWAppResponseBodyDataAuthenticationConfig : TeaModel {
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

            }
            [NameInMap("EncryptConfig")]
            [Validation(Required=false)]
            public GetGWAppResponseBodyDataEncryptConfig EncryptConfig { get; set; }
            public class GetGWAppResponseBodyDataEncryptConfig : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("EncryptionStatus")]
                [Validation(Required=false)]
                public string EncryptionStatus { get; set; }

                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                [NameInMap("KeyPair")]
                [Validation(Required=false)]
                public string KeyPair { get; set; }

                [NameInMap("PrivateKey")]
                [Validation(Required=false)]
                public string PrivateKey { get; set; }

                [NameInMap("PubKey")]
                [Validation(Required=false)]
                public string PubKey { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }
        };

    }

}
