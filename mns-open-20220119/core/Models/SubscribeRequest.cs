// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SubscribeRequest : TeaModel {
        /// <summary>
        /// The receiver endpoint. The format of the endpoint varies based on the terminal type.
        /// 
        /// *   If you set PushType to http, set Endpoint to an `HTTP URL that starts with http:// or https://`.
        /// *   If you set PushType to queue, set Endpoint to a `queue name`.
        /// *   If you set PushType to mpush, set Endpoint to an `AppKey`.
        /// *   If you set PushType to alisms, set Endpoint to a `mobile number`.
        /// *   If you set PushType to email, set Endpoint to an `email address`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// The tag that is used to filter messages. Only messages that have the same tag can be pushed. Set the value to a string of no more than 16 characters.
        /// 
        /// By default, no tag is specified to filter messages.
        /// </summary>
        [NameInMap("MessageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

        /// <summary>
        /// The content format of the messages that are pushed to the endpoint. Valid values:
        /// 
        /// *   XML
        /// *   JSON
        /// *   SIMPLIFIED
        /// </summary>
        [NameInMap("NotifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        /// <summary>
        /// The retry policy that is applied if an error occurs when Message Service (MNS) pushes messages to the endpoint. Valid values:
        /// 
        /// *   BACKOFF_RETRY
        /// *   EXPONENTIAL_DECAY_RETRY
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// The terminal type. Valid values:
        /// 
        /// *   http: HTTP services
        /// *   queue: queues
        /// *   mpush: mobile devices
        /// *   alisms: Alibaba Cloud Short Message Service (SMS)
        /// *   email: emails
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// The name of the subscription.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// The name of the topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
