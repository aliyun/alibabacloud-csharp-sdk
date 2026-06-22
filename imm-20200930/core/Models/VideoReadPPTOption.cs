// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoReadPPTOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to extract content from the presentation slides. Set this parameter to <c>true</c> to enable extraction.</para>
        /// </summary>
        [NameInMap("Extract")]
        [Validation(Required=false)]
        public bool? Extract { get; set; }

    }

}
