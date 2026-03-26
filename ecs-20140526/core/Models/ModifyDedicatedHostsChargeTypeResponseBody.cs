// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostsChargeTypeResponseBody : TeaModel {
        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstances FeeOfInstances { get; set; }
        public class ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstances : TeaModel {
            [NameInMap("FeeOfInstance")]
            [Validation(Required=false)]
            public List<ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstancesFeeOfInstance> FeeOfInstance { get; set; }
            public class ModifyDedicatedHostsChargeTypeResponseBodyFeeOfInstancesFeeOfInstance : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("Fee")]
                [Validation(Required=false)]
                public string Fee { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the order. This is returned only when the payment method is changed to subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20413515388****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B61C08E5-403A-46A2-96C1-F7B1216DB10C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
