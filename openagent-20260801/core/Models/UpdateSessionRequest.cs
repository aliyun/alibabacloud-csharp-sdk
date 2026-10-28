// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class UpdateSessionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to pin the session. If you do not specify this parameter, the pinned status remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// <para>The new title of the session. If you do not need to update the title, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Updated inspection session</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
