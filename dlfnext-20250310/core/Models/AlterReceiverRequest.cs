// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterReceiverRequest : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer A</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the sink.</para>
        /// 
        /// <b>Example:</b>
        /// <para>receiver_name</para>
        /// </summary>
        [NameInMap("receiverName")]
        [Validation(Required=false)]
        public string ReceiverName { get; set; }

    }

}
