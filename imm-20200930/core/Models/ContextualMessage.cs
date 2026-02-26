// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualMessage : TeaModel {
        /// <summary>
        /// <para>The message content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The files involved in the dialogue.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ContextualFile> Files { get; set; }

        /// <summary>
        /// <para>The role in the dialogue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
