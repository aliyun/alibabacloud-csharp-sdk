// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchGetFileMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata returned.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F84C6D9-5AC0-49F9-914D-F02678E3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
