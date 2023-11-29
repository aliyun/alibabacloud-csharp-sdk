// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAppliedConfigsResponseBody : TeaModel {
        /// <summary>
        /// The names of the Logtail configurations.
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<string> Configs { get; set; }

        /// <summary>
        /// The number of Logtail configurations.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
