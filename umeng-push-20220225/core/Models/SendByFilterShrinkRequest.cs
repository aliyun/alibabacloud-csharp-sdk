// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class SendByFilterShrinkRequest : TeaModel {
        [NameInMap("AndroidPayload")]
        [Validation(Required=false)]
        public string AndroidPayloadShrink { get; set; }

        [NameInMap("AndroidShortPayload")]
        [Validation(Required=false)]
        public AndroidShortPayload AndroidShortPayload { get; set; }

        [NameInMap("ChannelProperties")]
        [Validation(Required=false)]
        public string ChannelPropertiesShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;where&quot;:{&quot;and&quot;:[{&quot;or&quot;:[{&quot;app_version&quot;:&quot;&gt;=1.0&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("HarmonyPayload")]
        [Validation(Required=false)]
        public string HarmonyPayloadShrink { get; set; }

        [NameInMap("IosPayload")]
        [Validation(Required=false)]
        public string IosPayloadShrink { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string PolicyShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ProductionMode")]
        [Validation(Required=false)]
        public bool? ProductionMode { get; set; }

        [NameInMap("ReceiptType")]
        [Validation(Required=false)]
        public int? ReceiptType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://msg.umeng.com/upush/receipt">https://msg.umeng.com/upush/receipt</a></para>
        /// </summary>
        [NameInMap("ReceiptUrl")]
        [Validation(Required=false)]
        public string ReceiptUrl { get; set; }

        [NameInMap("ThirdPartyId")]
        [Validation(Required=false)]
        public string ThirdPartyId { get; set; }

        [NameInMap("callbackParams")]
        [Validation(Required=false)]
        public string CallbackParams { get; set; }

    }

}
