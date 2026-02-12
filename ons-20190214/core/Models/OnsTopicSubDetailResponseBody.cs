// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicSubDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicSubDetailResponseBodyData Data { get; set; }
        public class OnsTopicSubDetailResponseBodyData : TeaModel {
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public OnsTopicSubDetailResponseBodyDataSubscriptionDataList SubscriptionDataList { get; set; }
            public class OnsTopicSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                [NameInMap("SubscriptionDataList")]
                [Validation(Required=false)]
                public List<OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList> SubscriptionDataList { get; set; }
                public class OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList : TeaModel {
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("MessageModel")]
                    [Validation(Required=false)]
                    public string MessageModel { get; set; }

                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public string Online { get; set; }

                    [NameInMap("SubString")]
                    [Validation(Required=false)]
                    public string SubString { get; set; }

                }

            }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87B6207F-2908-42B5-A134-84956DCA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
