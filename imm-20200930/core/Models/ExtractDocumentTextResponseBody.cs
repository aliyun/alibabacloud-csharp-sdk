// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ExtractDocumentTextResponseBody : TeaModel {
        /// <summary>
        /// <para>The text content of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试内容。</para>
        /// </summary>
        [NameInMap("DocumentText")]
        [Validation(Required=false)]
        public string DocumentText { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94D6F994-E298-037E-8E8B-0090F27*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
