// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiHistoriesResponseBody : TeaModel {
        [NameInMap("ApiHisItems")]
        [Validation(Required=false)]
        public DescribeApiHistoriesResponseBodyApiHisItems ApiHisItems { get; set; }
        public class DescribeApiHistoriesResponseBodyApiHisItems : TeaModel {
            [NameInMap("ApiHisItem")]
            [Validation(Required=false)]
            public List<DescribeApiHistoriesResponseBodyApiHisItemsApiHisItem> ApiHisItem { get; set; }
            public class DescribeApiHistoriesResponseBodyApiHisItemsApiHisItem : TeaModel {
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string DeployedTime { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string HistoryVersion { get; set; }
                public string RegionId { get; set; }
                public string StageName { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
