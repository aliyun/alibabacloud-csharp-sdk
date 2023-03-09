// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180328.Models
{
    public class QueryFxCustomerRelationListResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFxCustomerRelationListResponseBodyData Data { get; set; }
        public class QueryFxCustomerRelationListResponseBodyData : TeaModel {
            [NameInMap("FxCustomerRelationVO")]
            [Validation(Required=false)]
            public List<QueryFxCustomerRelationListResponseBodyDataFxCustomerRelationVO> FxCustomerRelationVO { get; set; }
            public class QueryFxCustomerRelationListResponseBodyDataFxCustomerRelationVO : TeaModel {
                [NameInMap("CustomerRebateType")]
                [Validation(Required=false)]
                public int? CustomerRebateType { get; set; }

                [NameInMap("IsDistribution")]
                [Validation(Required=false)]
                public int? IsDistribution { get; set; }

                [NameInMap("IsRebateAgent")]
                [Validation(Required=false)]
                public int? IsRebateAgent { get; set; }

                /// <summary>
                /// level
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// parent
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// parent1
                /// </summary>
                [NameInMap("ParentId1")]
                [Validation(Required=false)]
                public long? ParentId1 { get; set; }

                /// <summary>
                /// parent2
                /// </summary>
                [NameInMap("ParentId2")]
                [Validation(Required=false)]
                public long? ParentId2 { get; set; }

                /// <summary>
                /// parentid3
                /// </summary>
                [NameInMap("ParentId3")]
                [Validation(Required=false)]
                public long? ParentId3 { get; set; }

                /// <summary>
                /// uid
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

        }

        /// <summary>
        /// msg
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
