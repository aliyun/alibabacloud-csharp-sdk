// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListGWOperatorResponseBody : TeaModel {
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
        public ListGWOperatorResponseBodyData Data { get; set; }
        public class ListGWOperatorResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGWOperatorResponseBodyDataList> List { get; set; }
            public class ListGWOperatorResponseBodyDataList : TeaModel {
                public string CreateTime { get; set; }
                public string Customer { get; set; }
                public string Email { get; set; }
                public string Id { get; set; }
                public string LoginName { get; set; }
                public string Mobile { get; set; }
                public string NickName { get; set; }
                public string RealName { get; set; }
                public string Status { get; set; }
                public string TenantId { get; set; }
                public string UpdateTime { get; set; }
                public string WorkspaceId { get; set; }
                public string WorkNo { get; set; }
                public List<string> Tenants { get; set; }
            }
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListGWOperatorResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListGWOperatorResponseBodyDataPageInfo : TeaModel {
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
                public List<ListGWOperatorResponseBodyDataPageInfoOrderInfos> OrderInfos { get; set; }
                public class ListGWOperatorResponseBodyDataPageInfoOrderInfos : TeaModel {
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
