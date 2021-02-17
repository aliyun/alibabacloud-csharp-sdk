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
            public OnsConsumerGetConnectionResponseBodyDataConnectionList ConnectionList { get; set; }
            public class OnsConsumerGetConnectionResponseBodyDataConnectionList : TeaModel {
                [NameInMap("ConnectionDo")]
                [Validation(Required=false)]
                public List<OnsConsumerGetConnectionResponseBodyDataConnectionListConnectionDo> ConnectionDo { get; set; }
                public class OnsConsumerGetConnectionResponseBodyDataConnectionListConnectionDo : TeaModel {
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                }

            }
        };

    }

}
