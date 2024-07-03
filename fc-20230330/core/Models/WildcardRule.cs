// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class WildcardRule : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("replacement")]
        [Validation(Required=false)]
        public string Replacement { get; set; }

    }

}
