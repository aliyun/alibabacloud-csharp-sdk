// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateExtensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the extension that you want to install. Multiple extension names are separated with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>citext, dblink</para>
        /// </summary>
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
