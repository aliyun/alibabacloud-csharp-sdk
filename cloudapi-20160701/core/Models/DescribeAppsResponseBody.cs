// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public DescribeAppsResponseBodyApps Apps { get; set; }
        public class DescribeAppsResponseBodyApps : TeaModel {
            [NameInMap("App")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyAppsApp> App { get; set; }
            public class DescribeAppsResponseBodyAppsApp : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

            }

        }

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
