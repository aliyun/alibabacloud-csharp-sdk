// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoReadKeywordOption : TeaModel {
        /// <summary>
        /// <para>Specifies the maximum number of keywords to return. The service may return fewer keywords than this limit. If omitted, the service returns all extracted keywords.</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Specifies whether to extract keywords from the video. Set to <c>true</c> to enable keyword extraction. The default is <c>false</c>.</para>
        /// </summary>
        [NameInMap("Extract")]
        [Validation(Required=false)]
        public bool? Extract { get; set; }

    }

}
