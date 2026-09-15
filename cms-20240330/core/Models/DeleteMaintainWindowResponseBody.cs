// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteMaintainWindowResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the deleted silence policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ff3fbd0-8a0b-4b31-9b1c-8e3f0a2c5d71</para>
        /// </summary>
        [NameInMap("maintainWindowId")]
        [Validation(Required=false)]
        public string MaintainWindowId { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID for troubleshooting and ticket tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A0D1C36</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
