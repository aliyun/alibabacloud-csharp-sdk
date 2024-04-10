// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetSubscriptionAttributesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionAttributesResponseBodyData Data { get; set; }
        public class GetSubscriptionAttributesResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("FilterTag")]
            [Validation(Required=false)]
            public string FilterTag { get; set; }

            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            [NameInMap("NotifyContentFormat")]
            [Validation(Required=false)]
            public string NotifyContentFormat { get; set; }

            [NameInMap("NotifyStrategy")]
            [Validation(Required=false)]
            public string NotifyStrategy { get; set; }

            [NameInMap("SubscriptionName")]
            [Validation(Required=false)]
            public string SubscriptionName { get; set; }

            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            [NameInMap("TopicOwner")]
            [Validation(Required=false)]
            public string TopicOwner { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
