// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CloseAICoachTaskSessionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0E06E0AA-D5B6-538C-8CE9-BAB79C68B690</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
