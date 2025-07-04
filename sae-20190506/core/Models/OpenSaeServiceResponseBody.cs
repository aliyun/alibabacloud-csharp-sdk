// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class OpenSaeServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>PushEvent</para>
        /// 
        /// <b>Example:</b>
        /// <para>20485646575****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>enableWAF</para>
        /// 
        /// <b>Example:</b>
        /// <para>559B4247-C41C-4D9E-B866-B55D378B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
