// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteBackupClientResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of HBR clients. The value can be a JSON array that consists of up to 100 client IDs. Separate the IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c-0007kyu045r0********&quot;, &quot;c-000b6818umvo********&quot;]</para>
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIdsShrink { get; set; }

    }

}
