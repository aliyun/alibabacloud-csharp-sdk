// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class CancelRunRequest : TeaModel {
        /// <summary>
        /// <para>The reason for the cancellation. The value must be 1 to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The user manually canceled this task</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
