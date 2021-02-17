// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageGetByKeyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageGetByKeyResponseBodyData Data { get; set; }
        public class OnsMessageGetByKeyResponseBodyData : TeaModel {
            [NameInMap("OnsRestMessageDo")]
            [Validation(Required=false)]
            public List<OnsMessageGetByKeyResponseBodyDataOnsRestMessageDo> OnsRestMessageDo { get; set; }
            public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDo : TeaModel {
                public int? StoreSize { get; set; }
                public int? ReconsumeTimes { get; set; }
                public long? StoreTimestamp { get; set; }
                public string InstanceId { get; set; }
                public string MsgId { get; set; }
                public string StoreHost { get; set; }
                public string Topic { get; set; }
                public OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyList PropertyList { get; set; }
                public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyList : TeaModel {
                    [NameInMap("MessageProperty")]
                    [Validation(Required=false)]
                    public List<OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyListMessageProperty> MessageProperty { get; set; }
                    public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyListMessageProperty : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public long? BornTimestamp { get; set; }
                public int? BodyCRC { get; set; }
                public string BornHost { get; set; }
            }
        };

    }

}
