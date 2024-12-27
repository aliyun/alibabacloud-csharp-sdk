// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SemanticQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The files.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C5C1E0F-D8B8-4DA0-8127-EC32C771****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
