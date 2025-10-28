// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetChangeOrderInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1074f3e2-e974-4a0e-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

    }

}
