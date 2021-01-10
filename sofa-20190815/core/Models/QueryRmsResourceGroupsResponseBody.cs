// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsResourceGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsResourceGroupsResponseBodyResponse Response { get; set; }
        public class QueryRmsResourceGroupsResponseBodyResponse : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryRmsResourceGroupsResponseBodyResponseData> Data { get; set; }
            public class QueryRmsResourceGroupsResponseBodyResponseData : TeaModel {
                public string GroupName { get; set; }
                public string GroupType { get; set; }
                public string Id { get; set; }
                public string OriginType { get; set; }
                public string ResType { get; set; }
                public string TenantId { get; set; }
                public string UtcCreated { get; set; }
                public string UtcModified { get; set; }
                public string WorkspaceId { get; set; }
                public List<string> ItemTypeAlerting { get; set; }
                public List<string> ItemTypeConfigured { get; set; }
                public List<QueryRmsResourceGroupsResponseBodyResponseDataLables> Lables { get; set; }
                public class QueryRmsResourceGroupsResponseBodyResponseDataLables : TeaModel {
                    public string ResId { get; set; }
                    public string ResName { get; set; }
                }
            }
        };

    }

}
