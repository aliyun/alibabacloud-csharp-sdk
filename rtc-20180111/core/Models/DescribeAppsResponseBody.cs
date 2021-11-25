// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        [NameInMap("AppList")]
        [Validation(Required=false)]
        public DescribeAppsResponseBodyAppList AppList { get; set; }
        public class DescribeAppsResponseBodyAppList : TeaModel {
            [NameInMap("App")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyAppListApp> App { get; set; }
            public class DescribeAppsResponseBodyAppListApp : TeaModel {
                public string AppId { get; set; }
                public string AppName { get; set; }
                public string AppType { get; set; }
                public string BillType { get; set; }
                public string CreateTime { get; set; }
                public DescribeAppsResponseBodyAppListAppServiceAreas ServiceAreas { get; set; }
                public class DescribeAppsResponseBodyAppListAppServiceAreas : TeaModel {
                    [NameInMap("ServiceArea")]
                    [Validation(Required=false)]
                    public List<string> ServiceArea { get; set; }

                }
                public int? Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
