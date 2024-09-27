// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyReservedInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the reserved instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED9E4A5F-FF4D-4C96-BE80-6B4227060DD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IDs of the reserved instances.</para>
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
