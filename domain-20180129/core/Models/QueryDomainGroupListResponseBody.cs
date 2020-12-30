// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainGroupListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDomainGroupListResponseBodyData Data { get; set; }
        public class QueryDomainGroupListResponseBodyData : TeaModel {
            [NameInMap("DomainGroup")]
            [Validation(Required=false)]
            public List<QueryDomainGroupListResponseBodyDataDomainGroup> DomainGroup { get; set; }
            public class QueryDomainGroupListResponseBodyDataDomainGroup : TeaModel {
                public bool? BeingDeleted { get; set; }
                public string DomainGroupStatus { get; set; }
                public string DomainGroupId { get; set; }
                public string DomainGroupName { get; set; }
                public string ModificationDate { get; set; }
                public int? TotalNumber { get; set; }
                public string CreationDate { get; set; }
            }
        };

    }

}
