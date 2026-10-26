// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class VerifySendMessageRequest : TeaModel {
        /// <summary>
        /// <para>The delivery time for a delayed message, specified as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1773718320000</para>
        /// </summary>
        [NameInMap("deliveryTimeStamp")]
        [Validation(Required=false)]
        public long? DeliveryTimeStamp { get; set; }

        /// <summary>
        /// <para>The name of the Lite Message Queue topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("liteTopicName")]
        [Validation(Required=false)]
        public string LiteTopicName { get; set; }

        /// <summary>
        /// <para>The message content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the message group. This parameter applies only to ordered messages. Messages with the same group ID are consumed in the order they are sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testMessageGroup</para>
        /// </summary>
        [NameInMap("messageGroup")]
        [Validation(Required=false)]
        public string MessageGroup { get; set; }

        /// <summary>
        /// <para>The business key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("messageKey")]
        [Validation(Required=false)]
        public string MessageKey { get; set; }

        /// <summary>
        /// <para>The message tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("messageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

        /// <summary>
        /// <para>The user-defined properties of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("userProperties")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserProperties { get; set; }

    }

}
