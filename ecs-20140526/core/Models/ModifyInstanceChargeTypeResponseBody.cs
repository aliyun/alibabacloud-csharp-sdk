// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceChargeTypeResponseBody : TeaModel {
        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public ModifyInstanceChargeTypeResponseBodyFeeOfInstances FeeOfInstances { get; set; }
        public class ModifyInstanceChargeTypeResponseBodyFeeOfInstances : TeaModel {
            [NameInMap("FeeOfInstance")]
            [Validation(Required=false)]
            public List<ModifyInstanceChargeTypeResponseBodyFeeOfInstancesFeeOfInstance> FeeOfInstance { get; set; }
            public class ModifyInstanceChargeTypeResponseBodyFeeOfInstancesFeeOfInstance : TeaModel {
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
        /// <para>The order ID.</para>
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
