// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateAccountWebhookRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the RAM user within the independent software vendor (ISV) account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493**</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use HTTP callbacks to receive message receipts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: indicates that HTTP callbacks are used to receive receipts.</description></item>
        /// <item><description>N: indicates that HTTP callbacks are not used to receive receipts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("HttpFlag")]
        [Validation(Required=false)]
        public string HttpFlag { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use Message Service (MNS) queues to receive receipts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: indicates that MNS queues are used to receive receipts.</description></item>
        /// <item><description>N: indicates that MNS queues are not used to receive receipts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("QueueFlag")]
        [Validation(Required=false)]
        public string QueueFlag { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The callback URL to which status reports are sent by using HTTP callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("StatusCallbackUrl")]
        [Validation(Required=false)]
        public string StatusCallbackUrl { get; set; }

    }

}
