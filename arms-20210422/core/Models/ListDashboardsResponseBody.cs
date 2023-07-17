// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class ListDashboardsResponseBody : TeaModel {
        [NameInMap("DashboardVos")]
        [Validation(Required=false)]
        public List<ListDashboardsResponseBodyDashboardVos> DashboardVos { get; set; }
        public class ListDashboardsResponseBodyDashboardVos : TeaModel {
            [NameInMap("DashboardType")]
            [Validation(Required=false)]
            public string DashboardType { get; set; }

            [NameInMap("Exporter")]
            [Validation(Required=false)]
            public string Exporter { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsArmsExporter")]
            [Validation(Required=false)]
            public bool? IsArmsExporter { get; set; }

            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NeedUpdate")]
            [Validation(Required=false)]
            public bool? NeedUpdate { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
