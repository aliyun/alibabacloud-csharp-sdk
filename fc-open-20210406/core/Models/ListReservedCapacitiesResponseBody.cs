// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListReservedCapacitiesResponseBody : TeaModel {
        /// <summary>
        /// The token used to obtain more results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about subscription instances.
        /// </summary>
        [NameInMap("reservedCapacities")]
        [Validation(Required=false)]
        public List<OpenReservedCapacity> ReservedCapacities { get; set; }

    }

}
