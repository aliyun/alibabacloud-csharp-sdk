// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualRetrievalResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E93D6C9-5AC0-49F9-914D-E02678D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of retrieved files. The document-related structural content is included in File.Elements.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<File> Results { get; set; }

    }

}
