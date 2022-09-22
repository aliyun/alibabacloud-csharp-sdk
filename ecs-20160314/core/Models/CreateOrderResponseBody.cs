// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateOrderResponseBody : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public CreateOrderResponseBodyOrderParams OrderParams { get; set; }
        public class CreateOrderResponseBodyOrderParams : TeaModel {
            [NameInMap("OrderParam")]
            [Validation(Required=false)]
            public List<string> OrderParam { get; set; }

        }

        [NameInMap("RelatedOrderItemSets")]
        [Validation(Required=false)]
        public CreateOrderResponseBodyRelatedOrderItemSets RelatedOrderItemSets { get; set; }
        public class CreateOrderResponseBodyRelatedOrderItemSets : TeaModel {
            [NameInMap("RelatedOrderItemSet")]
            [Validation(Required=false)]
            public List<CreateOrderResponseBodyRelatedOrderItemSetsRelatedOrderItemSet> RelatedOrderItemSet { get; set; }
            public class CreateOrderResponseBodyRelatedOrderItemSetsRelatedOrderItemSet : TeaModel {
                [NameInMap("InstanceIdSet")]
                [Validation(Required=false)]
                public CreateOrderResponseBodyRelatedOrderItemSetsRelatedOrderItemSetInstanceIdSet InstanceIdSet { get; set; }
                public class CreateOrderResponseBodyRelatedOrderItemSetsRelatedOrderItemSetInstanceIdSet : TeaModel {
                    [NameInMap("InstanceIds")]
                    [Validation(Required=false)]
                    public List<string> InstanceIds { get; set; }

                }

                [NameInMap("RelatedOrderIds")]
                [Validation(Required=false)]
                public CreateOrderResponseBodyRelatedOrderItemSetsRelatedOrderItemSetRelatedOrderIds RelatedOrderIds { get; set; }
                public class CreateOrderResponseBodyRelatedOrderItemSetsRelatedOrderItemSetRelatedOrderIds : TeaModel {
                    [NameInMap("RelatedOrderId")]
                    [Validation(Required=false)]
                    public List<string> RelatedOrderId { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
