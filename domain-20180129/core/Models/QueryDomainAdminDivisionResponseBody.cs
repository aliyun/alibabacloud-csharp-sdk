// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainAdminDivisionResponseBody : TeaModel {
        [NameInMap("AdminDivisions")]
        [Validation(Required=false)]
        public QueryDomainAdminDivisionResponseBodyAdminDivisions AdminDivisions { get; set; }
        public class QueryDomainAdminDivisionResponseBodyAdminDivisions : TeaModel {
            [NameInMap("AdminDivision")]
            [Validation(Required=false)]
            public List<QueryDomainAdminDivisionResponseBodyAdminDivisionsAdminDivision> AdminDivision { get; set; }
            public class QueryDomainAdminDivisionResponseBodyAdminDivisionsAdminDivision : TeaModel {
                public QueryDomainAdminDivisionResponseBodyAdminDivisionsAdminDivisionChildren Children { get; set; }
                public class QueryDomainAdminDivisionResponseBodyAdminDivisionsAdminDivisionChildren : TeaModel {
                    [NameInMap("Children")]
                    [Validation(Required=false)]
                    public List<QueryDomainAdminDivisionResponseBodyAdminDivisionsAdminDivisionChildrenChildren> Children { get; set; }
                    public class QueryDomainAdminDivisionResponseBodyAdminDivisionsAdminDivisionChildrenChildren : TeaModel {
                        [NameInMap("ChildDivisionName")]
                        [Validation(Required=false)]
                        public string ChildDivisionName { get; set; }

                    }

                }
                public string DivisionName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
