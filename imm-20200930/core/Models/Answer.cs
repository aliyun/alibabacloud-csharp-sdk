// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Answer : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>你好</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("References")]
        [Validation(Required=false)]
        public List<ReferenceFile> References { get; set; }

    }

}
