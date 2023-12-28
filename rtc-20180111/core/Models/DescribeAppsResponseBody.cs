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
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ServiceAreas")]
                [Validation(Required=false)]
                public DescribeAppsResponseBodyAppListAppServiceAreas ServiceAreas { get; set; }
                public class DescribeAppsResponseBodyAppListAppServiceAreas : TeaModel {
                    [NameInMap("ServiceArea")]
                    [Validation(Required=false)]
                    public List<string> ServiceArea { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

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
