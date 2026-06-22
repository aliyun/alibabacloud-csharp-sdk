// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentReadKeywordOption : TeaModel {
        /// <summary>
        /// <para>The maximum number of keywords to return.</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Whether to extract keywords from the document.</para>
        /// </summary>
        [NameInMap("Extract")]
        [Validation(Required=false)]
        public bool? Extract { get; set; }

    }

}
