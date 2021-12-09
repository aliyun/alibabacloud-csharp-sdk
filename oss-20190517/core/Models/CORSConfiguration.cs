// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CORSConfiguration : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("CORSRule")]
        [Validation(Required=false)]
        public List<CORSRule> CORSRule { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("ResponseVary")]
        [Validation(Required=false)]
        public bool? ResponseVary { get; set; }

    }

}
