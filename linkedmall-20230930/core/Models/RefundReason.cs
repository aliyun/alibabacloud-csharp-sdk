// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundReason : TeaModel {
        /// <summary>
        /// <para>Is upload credential required</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("proofRequired")]
        [Validation(Required=false)]
        public bool? ProofRequired { get; set; }

        /// <summary>
        /// <para>Reason text ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>47683</para>
        /// </summary>
        [NameInMap("reasonTextId")]
        [Validation(Required=false)]
        public string ReasonTextId { get; set; }

        /// <summary>
        /// <para>Reason text</para>
        /// 
        /// <b>Example:</b>
        /// <para>不想要了</para>
        /// </summary>
        [NameInMap("reasonTips")]
        [Validation(Required=false)]
        public string ReasonTips { get; set; }

        /// <summary>
        /// <para>Is a message required</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("refundDescRequired")]
        [Validation(Required=false)]
        public bool? RefundDescRequired { get; set; }

    }

}
