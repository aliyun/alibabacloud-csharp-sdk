// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMachineGroupResponseBody : TeaModel {
        /// <summary>
        /// The number of machine groups that are returned on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The machine groups that meet the query conditions.
        /// </summary>
        [NameInMap("machinegroups")]
        [Validation(Required=false)]
        public List<string> Machinegroups { get; set; }

        /// <summary>
        /// The total number of machine groups that meet the query conditions.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
