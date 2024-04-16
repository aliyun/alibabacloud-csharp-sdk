// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListEnvironmentOverviewsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentOverviewsResponseBodyData Data { get; set; }
        public class ListEnvironmentOverviewsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListEnvironmentOverviewsResponseBodyDataItems> Items { get; set; }
            public class ListEnvironmentOverviewsResponseBodyDataItems : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public Dictionary<string, string> Config { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CurrentPublish")]
                [Validation(Required=false)]
                public Dictionary<string, string> CurrentPublish { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("EnvId")]
                [Validation(Required=false)]
                public string EnvId { get; set; }

                [NameInMap("EnvStatus")]
                [Validation(Required=false)]
                public string EnvStatus { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("LatestAppAccessTime")]
                [Validation(Required=false)]
                public string LatestAppAccessTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("OpsRecord")]
                [Validation(Required=false)]
                public Dictionary<string, string> OpsRecord { get; set; }

                [NameInMap("Publishing")]
                [Validation(Required=false)]
                public Dictionary<string, string> Publishing { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
