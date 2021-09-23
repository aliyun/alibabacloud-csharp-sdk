// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Row : TeaModel {
        /// <summary>
        /// URI
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        /// <summary>
        /// CustomLabels
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public List<KeyValuePair> CustomLabels { get; set; }

    }

}
