// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public DescribeAppsResponseBodyApps Apps { get; set; }
        public class DescribeAppsResponseBodyApps : TeaModel {
            [NameInMap("AppItem")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyAppsAppItem> AppItem { get; set; }
            public class DescribeAppsResponseBodyAppsAppItem : TeaModel {
                public long? AppId { get; set; }
                public string AppName { get; set; }
                public string Description { get; set; }
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
