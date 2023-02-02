// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupSubDetailResponseBody : TeaModel {
        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsGroupSubDetailResponseBodyData Data { get; set; }
        public class OnsGroupSubDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the consumer group that you want to query.
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
            /// Indicates whether consumers in the group are online.
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// The topics to which consumers in the consumer group subscribe. If all consumers in the specified group are offline, no topics are returned.
            /// </summary>
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public OnsGroupSubDetailResponseBodyDataSubscriptionDataList SubscriptionDataList { get; set; }
            public class OnsGroupSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                [NameInMap("SubscriptionDataList")]
                [Validation(Required=false)]
                public List<OnsGroupSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList> SubscriptionDataList { get; set; }
                public class OnsGroupSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList : TeaModel {
                    /// <summary>
                    /// The expression based on which consumers in the consumer group subscribe to the topic.
                    /// </summary>
                    [NameInMap("SubString")]
                    [Validation(Required=false)]
                    public string SubString { get; set; }

                    /// <summary>
                    /// The name of the topic to which consumers in the consumer group subscribe.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
