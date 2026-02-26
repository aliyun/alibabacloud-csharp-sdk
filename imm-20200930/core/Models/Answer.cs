// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Answer : TeaModel {
        /// <summary>
        /// <para>The answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The reference sources of the answer.</para>
        /// </summary>
        [NameInMap("References")]
        [Validation(Required=false)]
        public List<ReferenceFile> References { get; set; }

    }

}
