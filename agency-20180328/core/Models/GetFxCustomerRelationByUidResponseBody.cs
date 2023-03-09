// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180328.Models
{
    public class GetFxCustomerRelationByUidResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FxCustomerRelationVO")]
        [Validation(Required=false)]
        public GetFxCustomerRelationByUidResponseBodyFxCustomerRelationVO FxCustomerRelationVO { get; set; }
        public class GetFxCustomerRelationByUidResponseBodyFxCustomerRelationVO : TeaModel {
            [NameInMap("CustomerRebateType")]
            [Validation(Required=false)]
            public int? CustomerRebateType { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsDistribution")]
            [Validation(Required=false)]
            public int? IsDistribution { get; set; }

            /// <summary>
            /// level
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            /// <summary>
            /// parentId
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// parentId1
            /// </summary>
            [NameInMap("ParentId1")]
            [Validation(Required=false)]
            public long? ParentId1 { get; set; }

            /// <summary>
            /// uid
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        /// <summary>
        /// message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
