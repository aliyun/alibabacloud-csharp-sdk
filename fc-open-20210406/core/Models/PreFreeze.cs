// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PreFreeze : TeaModel {
        /// <summary>
        /// preFreeze handler name
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// handler timeout
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
