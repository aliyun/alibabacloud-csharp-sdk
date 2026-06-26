// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CreateReceiverRequest : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer A.</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the receiver.</para>
        /// 
        /// <b>Example:</b>
        /// <para>receiver_name</para>
        /// </summary>
        [NameInMap("receiverName")]
        [Validation(Required=false)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// <para>The ID of the receiver\&quot;s account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("receiverTenantId")]
        [Validation(Required=false)]
        public long? ReceiverTenantId { get; set; }

    }

}
