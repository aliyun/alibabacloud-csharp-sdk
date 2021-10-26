// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class OSSTriggerKey : TeaModel {
        /// <summary>
        /// prefix
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// suffix
        /// </summary>
        [NameInMap("suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

    }

}
