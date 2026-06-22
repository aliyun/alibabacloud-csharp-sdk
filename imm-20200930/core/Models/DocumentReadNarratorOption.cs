// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentReadNarratorOption : TeaModel {
        /// <summary>
        /// <para>Whether to enable the document narration feature. Set to <c>true</c> to enable narration. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("Narrate")]
        [Validation(Required=false)]
        public bool? Narrate { get; set; }

    }

}
