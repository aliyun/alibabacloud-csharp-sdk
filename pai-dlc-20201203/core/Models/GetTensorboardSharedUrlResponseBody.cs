// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTensorboardSharedUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The shareable link of the TensorBoard task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://pai-dlc-proxy-xxx.alicyuncs.com/xxx/xxx/token/">http://pai-dlc-proxy-xxx.alicyuncs.com/xxx/xxx/token/</a></para>
        /// </summary>
        [NameInMap("TensorboardSharedUrl")]
        [Validation(Required=false)]
        public string TensorboardSharedUrl { get; set; }

    }

}
