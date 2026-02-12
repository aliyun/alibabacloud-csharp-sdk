// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsDLQMessagePageQueryByGroupIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about dead-letter messages that are queried.</para>
        /// </summary>
        [NameInMap("MsgFoundDo")]
        [Validation(Required=false)]
        public OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDo MsgFoundDo { get; set; }
        public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDo : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The total number of returned pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("MaxPageCount")]
            [Validation(Required=false)]
            public long? MaxPageCount { get; set; }

            [NameInMap("MsgFoundList")]
            [Validation(Required=false)]
            public OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundList MsgFoundList { get; set; }
            public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundList : TeaModel {
                [NameInMap("OnsRestMessageDo")]
                [Validation(Required=false)]
                public List<OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDo> OnsRestMessageDo { get; set; }
                public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDo : TeaModel {
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
                    public OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyList PropertyList { get; set; }
                    public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyList : TeaModel {
                        [NameInMap("MessageProperty")]
                        [Validation(Required=false)]
                        public List<OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyListMessageProperty> MessageProperty { get; set; }
                        public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyListMessageProperty : TeaModel {
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
            /// <para>The ID of the query task. The first time you call this operation to query the dead-letter messages that are sent to a specified consumer group within a specified time range, this parameter is returned. You can use the task ID to query the details of dead-letter messages on other returned pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0BC1310300002A9F000021E4D7A48346</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B00CD3C8-D81E-4A41-85E2-38F19252****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
