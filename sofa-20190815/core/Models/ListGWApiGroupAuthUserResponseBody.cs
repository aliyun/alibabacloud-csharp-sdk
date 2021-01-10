// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListGWApiGroupAuthUserResponseBody : TeaModel {
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
        public ListGWApiGroupAuthUserResponseBodyData Data { get; set; }
        public class ListGWApiGroupAuthUserResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGWApiGroupAuthUserResponseBodyDataList> List { get; set; }
            public class ListGWApiGroupAuthUserResponseBodyDataList : TeaModel {
                public string ApiGroupId { get; set; }
                public string ApiId { get; set; }
                public string AuthStatus { get; set; }
                public string AuthUserId { get; set; }
                public bool? CanAuth { get; set; }
                public string Customer { get; set; }
                public string Email { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string LoginName { get; set; }
                public string Mobile { get; set; }
                public string NickName { get; set; }
                public string Operator { get; set; }
                public string RealName { get; set; }
                public string Status { get; set; }
                public string TenantId { get; set; }
                public string UserId { get; set; }
                public string WorkspaceId { get; set; }
                public string WorkNo { get; set; }
            }
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListGWApiGroupAuthUserResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListGWApiGroupAuthUserResponseBodyDataPageInfo : TeaModel {
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
                public List<ListGWApiGroupAuthUserResponseBodyDataPageInfoOrderInfos> OrderInfos { get; set; }
                public class ListGWApiGroupAuthUserResponseBodyDataPageInfoOrderInfos : TeaModel {
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
