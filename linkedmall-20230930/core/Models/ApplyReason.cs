// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ApplyReason : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>403769</para>
        /// </summary>
        [NameInMap("reasonTextId")]
        [Validation(Required=false)]
        public long? ReasonTextId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>不想要了</para>
        /// </summary>
        [NameInMap("reasonTips")]
        [Validation(Required=false)]
        public string ReasonTips { get; set; }

    }

}
