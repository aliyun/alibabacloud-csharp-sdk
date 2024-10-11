// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class PreloadVodObjectCachesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the prefetch task. Separate multiple task IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>9524****</para>
        /// </summary>
        [NameInMap("PreloadTaskId")]
        [Validation(Required=false)]
        public string PreloadTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5BD4B50-7A02-493A-*****-97B9024B4135</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
