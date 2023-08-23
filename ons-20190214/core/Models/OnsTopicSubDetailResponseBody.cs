// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicSubDetailResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicSubDetailResponseBodyData Data { get; set; }
        public class OnsTopicSubDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the online consumer groups that subscribe to the topic.
            /// </summary>
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public OnsTopicSubDetailResponseBodyDataSubscriptionDataList SubscriptionDataList { get; set; }
            public class OnsTopicSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                [NameInMap("SubscriptionDataList")]
                [Validation(Required=false)]
                public List<OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList> SubscriptionDataList { get; set; }
                public class OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList : TeaModel {
                    /// <summary>
                    /// The ID of the consumer group that subscribes to the topic.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// The consumption mode. Valid values:
                    /// 
                    /// *   **CLUSTERING**: the clustering consumption mode
                    /// *   **BROADCASTING**: the broadcasting consumption mode
                    /// 
                    /// For more information about consumption modes, see [Clustering consumption and broadcasting consumption](~~43163~~).
                    /// </summary>
                    [NameInMap("MessageModel")]
                    [Validation(Required=false)]
                    public string MessageModel { get; set; }

                    /// <summary>
                    /// The expression based on which consumers in the consumer group subscribe to the topic.
                    /// </summary>
                    [NameInMap("SubString")]
                    [Validation(Required=false)]
                    public string SubString { get; set; }

                }

            }

            /// <summary>
            /// The topic name.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
