// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAppliedMachineGroupsResponseBody : TeaModel {
        /// <summary>
        /// The number of returned machine groups.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The names of the returned machine groups.
        /// </summary>
        [NameInMap("machinegroups")]
        [Validation(Required=false)]
        public List<string> Machinegroups { get; set; }

    }

}
