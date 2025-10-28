// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AbortChangeOrderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change process. You can call the <a href="https://help.aliyun.com/document_detail/62072.html">GetChangeOrderInfo</a> operation to query the change process ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f038ddf-b27b-<b><b>-</b></b>-88e44375****</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

    }

}
