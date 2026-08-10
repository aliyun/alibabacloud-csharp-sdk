// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class UpdateInfiniteCanvasResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the infinite canvas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>canvas_gesad*</para>
        /// </summary>
        [NameInMap("CanvasId")]
        [Validation(Required=false)]
        public string CanvasId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
