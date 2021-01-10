// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListGWAppResponseBody : TeaModel {
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
        public ListGWAppResponseBodyData Data { get; set; }
        public class ListGWAppResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGWAppResponseBodyDataList> List { get; set; }
            public class ListGWAppResponseBodyDataList : TeaModel {
                public long? ApiCount { get; set; }
                public string AppId { get; set; }
                public string AppName { get; set; }
                public string AppSecret { get; set; }
                public string AppType { get; set; }
                public bool? CanDelete { get; set; }
                public string Description { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string Operator { get; set; }
                public string TenantId { get; set; }
                public string WorkspaceId { get; set; }
                public ListGWAppResponseBodyDataListAuthenticationConfig AuthenticationConfig { get; set; }
                public class ListGWAppResponseBodyDataListAuthenticationConfig : TeaModel {
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    [NameInMap("SecretKey")]
                    [Validation(Required=false)]
                    public string SecretKey { get; set; }

                }
                public ListGWAppResponseBodyDataListEncryptConfig EncryptConfig { get; set; }
                public class ListGWAppResponseBodyDataListEncryptConfig : TeaModel {
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
            }
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListGWAppResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListGWAppResponseBodyDataPageInfo : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("OrderInfos")]
                [Validation(Required=false)]
                public List<ListGWAppResponseBodyDataPageInfoOrderInfos> OrderInfos { get; set; }
                public class ListGWAppResponseBodyDataPageInfoOrderInfos : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Order")]
                    [Validation(Required=false)]
                    public string Order { get; set; }

                }

            }
        };

    }

}
