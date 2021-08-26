// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SubtitleStream : TeaModel {
        /// <summary>
        /// Index
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// Content
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
