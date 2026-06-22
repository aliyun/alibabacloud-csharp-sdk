// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoReadQuestionOption : TeaModel {
        /// <summary>
        /// <para>Specifies the maximum number of answers to return when <c>Extract</c> is <c>true</c>. If omitted, the service returns all detected answers.</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Specifies whether to extract answer segments from the video. When <c>true</c>, the service identifies and returns these segments. The default is <c>false</c>.</para>
        /// </summary>
        [NameInMap("Extract")]
        [Validation(Required=false)]
        public bool? Extract { get; set; }

    }

}
