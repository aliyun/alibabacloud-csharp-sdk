// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListGWApiGroupResponseBody : TeaModel {
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
        public ListGWApiGroupResponseBodyData Data { get; set; }
        public class ListGWApiGroupResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGWApiGroupResponseBodyDataList> List { get; set; }
            public class ListGWApiGroupResponseBodyDataList : TeaModel {
                public long? ApiCount { get; set; }
                public string ApiGroupId { get; set; }
                public string AuthUserSwitch { get; set; }
                public bool? CanDelete { get; set; }
                public bool? CanOperate { get; set; }
                public string Description { get; set; }
                public string DomainName { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string GroupName { get; set; }
                public bool? NeedApiAuthUser { get; set; }
                public string Operator { get; set; }
                public string TenantId { get; set; }
                public string WorkspaceId { get; set; }
            }
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListGWApiGroupResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListGWApiGroupResponseBodyDataPageInfo : TeaModel {
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
                public List<ListGWApiGroupResponseBodyDataPageInfoOrderInfos> OrderInfos { get; set; }
                public class ListGWApiGroupResponseBodyDataPageInfoOrderInfos : TeaModel {
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
