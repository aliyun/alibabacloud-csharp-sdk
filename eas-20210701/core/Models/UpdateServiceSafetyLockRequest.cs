// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceSafetyLockRequest : TeaModel {
        /// <summary>
        /// <para>The lock scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: locks all operations.</description></item>
        /// <item><description>dangerous: locks dangerous operations such as delete and stop operations.</description></item>
        /// <item><description>none: locks no operations.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dangerous</para>
        /// </summary>
        [NameInMap("Lock")]
        [Validation(Required=false)]
        public string Lock { get; set; }

    }

}
