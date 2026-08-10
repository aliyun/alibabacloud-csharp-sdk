// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateInfiniteCanvasResponseBody : TeaModel {
        /// <summary>
        /// <para>The canvas ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>canvas_***</para>
        /// </summary>
        [NameInMap("CanvasId")]
        [Validation(Required=false)]
        public string CanvasId { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
