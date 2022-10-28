// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowEdgesByConditionResponseBody : TeaModel {
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public ListTaskFlowEdgesByConditionResponseBodyEdges Edges { get; set; }
        public class ListTaskFlowEdgesByConditionResponseBodyEdges : TeaModel {
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<ListTaskFlowEdgesByConditionResponseBodyEdgesEdge> Edge { get; set; }
            public class ListTaskFlowEdgesByConditionResponseBodyEdgesEdge : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("NodeEnd")]
                [Validation(Required=false)]
                public long? NodeEnd { get; set; }

                [NameInMap("NodeFrom")]
                [Validation(Required=false)]
                public long? NodeFrom { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
