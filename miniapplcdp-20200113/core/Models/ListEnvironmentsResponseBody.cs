// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListEnvironmentsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentsResponseBodyData Data { get; set; }
        public class ListEnvironmentsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListEnvironmentsResponseBodyDataItems> Items { get; set; }
            public class ListEnvironmentsResponseBodyDataItems : TeaModel {
                [NameInMap("AccountOpsEndpoint")]
                [Validation(Required=false)]
                public string AccountOpsEndpoint { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CurrentPublishId")]
                [Validation(Required=false)]
                public string CurrentPublishId { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("EnvId")]
                [Validation(Required=false)]
                public string EnvId { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("PublishingId")]
                [Validation(Required=false)]
                public string PublishingId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
