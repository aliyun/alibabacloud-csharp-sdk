// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMassMessageShrinkRequest : TeaModel {
        /// <summary>
        /// The channel type. Valid values: whatsapp, viber, and line.
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// The space ID of the user.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The ID of the WhatApp Business account of the ISV account.
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// The fallback content.
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// The ID of the fallback strategy.
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// The message sender.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ISV verification code, which is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// Viber消息类型，取值：pormotion或transation。
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// The language. For more information about language codes, see [Language codes](~~463420~~).
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The list of phone numbers that receive the message.
        /// </summary>
        [NameInMap("SenderList")]
        [Validation(Required=false)]
        public string SenderListShrink { get; set; }

        /// <summary>
        /// Viber消息发送时tag信息。
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The code of the message template.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// Viber消息发送超时时间，单位：秒，取值范围 30~1209600。
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
