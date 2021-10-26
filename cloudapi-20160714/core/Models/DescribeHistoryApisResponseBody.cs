// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeHistoryApisResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ApiHisItems")]
        [Validation(Required=false)]
        public DescribeHistoryApisResponseBodyApiHisItems ApiHisItems { get; set; }
        public class DescribeHistoryApisResponseBodyApiHisItems : TeaModel {
            [NameInMap("ApiHisItem")]
            [Validation(Required=false)]
            public List<DescribeHistoryApisResponseBodyApiHisItemsApiHisItem> ApiHisItem { get; set; }
            public class DescribeHistoryApisResponseBodyApiHisItemsApiHisItem : TeaModel {
                public string Status { get; set; }
                public string ApiId { get; set; }
                public string Description { get; set; }
                public string GroupName { get; set; }
                public string GroupId { get; set; }
                public string DeployedTime { get; set; }
                public string StageName { get; set; }
                public string HistoryVersion { get; set; }
                public string ApiName { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
