// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ResumeSessionRequest : TeaModel {
        [NameInMap("fileSystemOnly")]
        [Validation(Required=false)]
        public bool? FileSystemOnly { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliasName1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
