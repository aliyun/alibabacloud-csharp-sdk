// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetInfiniteCanvasRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the infinite canvas.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>canvas_***</para>
        /// </summary>
        [NameInMap("CanvasId")]
        [Validation(Required=false)]
        public string CanvasId { get; set; }

    }

}
