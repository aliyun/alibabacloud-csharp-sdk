// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageGetByKeyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageGetByKeyResponseBodyData Data { get; set; }
        public class OnsMessageGetByKeyResponseBodyData : TeaModel {
            [NameInMap("OnsRestMessageDo")]
            [Validation(Required=false)]
            public List<OnsMessageGetByKeyResponseBodyDataOnsRestMessageDo> OnsRestMessageDo { get; set; }
            public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDo : TeaModel {
                [NameInMap("BodyCRC")]
                [Validation(Required=false)]
                public int? BodyCRC { get; set; }

                [NameInMap("BornHost")]
                [Validation(Required=false)]
                public string BornHost { get; set; }

                [NameInMap("BornTimestamp")]
                [Validation(Required=false)]
                public long? BornTimestamp { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("MsgId")]
                [Validation(Required=false)]
                public string MsgId { get; set; }

                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyList PropertyList { get; set; }
                public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyList : TeaModel {
                    [NameInMap("MessageProperty")]
                    [Validation(Required=false)]
                    public List<OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyListMessageProperty> MessageProperty { get; set; }
                    public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyListMessageProperty : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("ReconsumeTimes")]
                [Validation(Required=false)]
                public int? ReconsumeTimes { get; set; }

                [NameInMap("StoreHost")]
                [Validation(Required=false)]
                public string StoreHost { get; set; }

                [NameInMap("StoreSize")]
                [Validation(Required=false)]
                public int? StoreSize { get; set; }

                [NameInMap("StoreTimestamp")]
                [Validation(Required=false)]
                public long? StoreTimestamp { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A07E3902-B92E-44A6-B6C5-6AA111111****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
