// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SubscribeRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("MessageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

        [NameInMap("NotifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
