// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerGetConnectionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerGetConnectionResponseBodyData Data { get; set; }
        public class OnsConsumerGetConnectionResponseBodyData : TeaModel {
            [NameInMap("ConnectionList")]
            [Validation(Required=false)]
            public List<OnsConsumerGetConnectionResponseBodyDataConnectionList> ConnectionList { get; set; }
            public class OnsConsumerGetConnectionResponseBodyDataConnectionList : TeaModel {
                public string Version { get; set; }
                public string ClientAddr { get; set; }
                public string Language { get; set; }
                public string ClientId { get; set; }
            }
        };

    }

}
