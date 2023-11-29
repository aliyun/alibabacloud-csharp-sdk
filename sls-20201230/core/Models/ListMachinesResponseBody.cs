// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMachinesResponseBody : TeaModel {
        /// <summary>
        /// The number of machines that are returned on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The machines that are returned.
        /// </summary>
        [NameInMap("machines")]
        [Validation(Required=false)]
        public List<Machine> Machines { get; set; }

        /// <summary>
        /// The total number of machines.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
