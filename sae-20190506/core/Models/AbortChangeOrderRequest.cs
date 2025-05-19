// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class AbortChangeOrderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>be2e1c76-682b-4897-98d3-1d8d6478****</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

        [NameInMap("Rollback")]
        [Validation(Required=false)]
        public bool? Rollback { get; set; }

    }

}
