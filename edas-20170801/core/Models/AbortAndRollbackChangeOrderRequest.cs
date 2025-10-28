// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AbortAndRollbackChangeOrderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b55106c-c7f2-40f7-a1d4-092870*****</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

    }

}
