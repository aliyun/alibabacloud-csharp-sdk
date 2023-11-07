// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainGroupListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDomainGroupListResponseBodyData Data { get; set; }
        public class QueryDomainGroupListResponseBodyData : TeaModel {
            [NameInMap("DomainGroup")]
            [Validation(Required=false)]
            public List<QueryDomainGroupListResponseBodyDataDomainGroup> DomainGroup { get; set; }
            public class QueryDomainGroupListResponseBodyDataDomainGroup : TeaModel {
                [NameInMap("BeingDeleted")]
                [Validation(Required=false)]
                public bool? BeingDeleted { get; set; }

                [NameInMap("CreationDate")]
                [Validation(Required=false)]
                public string CreationDate { get; set; }

                [NameInMap("DomainGroupId")]
                [Validation(Required=false)]
                public string DomainGroupId { get; set; }

                [NameInMap("DomainGroupName")]
                [Validation(Required=false)]
                public string DomainGroupName { get; set; }

                [NameInMap("DomainGroupStatus")]
                [Validation(Required=false)]
                public string DomainGroupStatus { get; set; }

                [NameInMap("ModificationDate")]
                [Validation(Required=false)]
                public string ModificationDate { get; set; }

                [NameInMap("TotalNumber")]
                [Validation(Required=false)]
                public int? TotalNumber { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
