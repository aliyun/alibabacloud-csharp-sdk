// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateChatFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Business tenant code, default is “ALICOM_OPAAS”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>Business extension information, default is “{}”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public string BizExtendShrink { get; set; }

        /// <summary>
        /// <para>Process code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4912c16943b4dfba44bd6fedacf8c70</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Process remarks</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is Customer Service WhatsApp Auto-Reply Flow</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Process title</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer Service WhatsApp Auto-Reply Flow</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
