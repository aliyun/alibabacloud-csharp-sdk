// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeCountConstraint : TeaModel {
        [NameInMap("Max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        [NameInMap("Min")]
        [Validation(Required=false)]
        public int? Min { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<int?> Values { get; set; }

    }

}
