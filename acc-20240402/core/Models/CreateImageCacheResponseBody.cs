// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acc20240402.Models
{
    public class CreateImageCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imc-bp1dj*****</para>
        /// </summary>
        [NameInMap("ImageCacheId")]
        [Validation(Required=false)]
        public string ImageCacheId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E234675-3465-4CC3-9D0F-9A864BC*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
