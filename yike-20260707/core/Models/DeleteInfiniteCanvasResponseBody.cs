// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class DeleteInfiniteCanvasResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the infinite canvas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>canvas_adaasd*</para>
        /// </summary>
        [NameInMap("CanvasId")]
        [Validation(Required=false)]
        public string CanvasId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b>F88A3-AC51-5588-859A-03144F082</b></em></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
