// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyReservedInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details about the reserved instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The IDs of the reserved instances.
        /// </summary>
        [NameInMap("ReservedInstanceIdSets")]
        [Validation(Required=false)]
        public ModifyReservedInstancesResponseBodyReservedInstanceIdSets ReservedInstanceIdSets { get; set; }
        public class ModifyReservedInstancesResponseBodyReservedInstanceIdSets : TeaModel {
            [NameInMap("ReservedInstanceId")]
            [Validation(Required=false)]
            public List<string> ReservedInstanceId { get; set; }

        }

    }

}
