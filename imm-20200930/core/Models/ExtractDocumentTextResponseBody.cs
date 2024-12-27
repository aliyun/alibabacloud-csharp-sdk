// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ExtractDocumentTextResponseBody : TeaModel {
        [NameInMap("DocumentText")]
        [Validation(Required=false)]
        public string DocumentText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>94D6F994-E298-037E-8E8B-0090F27*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
