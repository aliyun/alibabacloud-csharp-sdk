// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class IndexDocument : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("SupportSubDir")]
        [Validation(Required=false)]
        public bool? SupportSubDir { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
