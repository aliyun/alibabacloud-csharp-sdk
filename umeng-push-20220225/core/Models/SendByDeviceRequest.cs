// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class SendByDeviceRequest : TeaModel {
        [NameInMap("AndroidPayload")]
        [Validation(Required=false)]
        public AndroidPayload AndroidPayload { get; set; }

        [NameInMap("ChannelProperties")]
        [Validation(Required=false)]
        public ChannelProperties ChannelProperties { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ArdNyIzFCH2K3szXA8arpu0Y7ywOdA67mCSumtpnMnmf</para>
        /// </summary>
        [NameInMap("DeviceTokens")]
        [Validation(Required=false)]
        public string DeviceTokens { get; set; }

        [NameInMap("IosPayload")]
        [Validation(Required=false)]
        public IosPayload IosPayload { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public Policy Policy { get; set; }

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

    }

}
