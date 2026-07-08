// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DeleteWarehouseRequest : TeaModel {
        /// <summary>
        /// <para>The certificate warehouse instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-wh-Q7ID6V</para>
        /// </summary>
        [NameInMap("WarehouseInstanceId")]
        [Validation(Required=false)]
        public string WarehouseInstanceId { get; set; }

    }

}
