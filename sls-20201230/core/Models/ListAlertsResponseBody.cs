// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAlertsResponseBody : TeaModel {
        /// <summary>
        /// The number of alert rules that are returned.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The alert rules.
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<Alert> Results { get; set; }

        /// <summary>
        /// The total number of alert rules in the project.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
