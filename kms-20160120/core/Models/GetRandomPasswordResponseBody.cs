// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetRandomPasswordResponseBody : TeaModel {
        /// <summary>
        /// <para>The generated random password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IxGn&gt;NMmNB(y?iZ&lt;Yc,_H/{2GC\&quot;U****</para>
        /// </summary>
        [NameInMap("RandomPassword")]
        [Validation(Required=false)]
        public string RandomPassword { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b0cbe25-5e33-467e-972e-7a83c6c97604</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
