// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class ListBaaSFabricChannelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBaaSFabricChannelResponseBodyData> Data { get; set; }
        public class ListBaaSFabricChannelResponseBodyData : TeaModel {
            [NameInMap("BaaSFabricChannelId")]
            [Validation(Required=false)]
            public string BaaSFabricChannelId { get; set; }

            [NameInMap("BaaSFabricChannelName")]
            [Validation(Required=false)]
            public string BaaSFabricChannelName { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
