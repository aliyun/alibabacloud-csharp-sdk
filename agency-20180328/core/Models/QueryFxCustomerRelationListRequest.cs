// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180328.Models
{
    public class QueryFxCustomerRelationListRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("CustomerRebateType")]
        [Validation(Required=false)]
        public int? CustomerRebateType { get; set; }

        [NameInMap("GmtCreateMax")]
        [Validation(Required=false)]
        public string GmtCreateMax { get; set; }

        [NameInMap("GmtCreateMin")]
        [Validation(Required=false)]
        public string GmtCreateMin { get; set; }

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

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// uid
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
