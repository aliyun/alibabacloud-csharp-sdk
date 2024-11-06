// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PreloadDcdnObjectCachesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the prefetch task. Multiple IDs are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>95248880</para>
        /// </summary>
        [NameInMap("PreloadTaskId")]
        [Validation(Required=false)]
        public string PreloadTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5BD4B50-7A02-493A-AE0B-97B9024B4135</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
