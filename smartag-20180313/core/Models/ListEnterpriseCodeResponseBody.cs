// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListEnterpriseCodeResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("EnterpriseCodes")]
        [Validation(Required=false)]
        public List<ListEnterpriseCodeResponseBodyEnterpriseCodes> EnterpriseCodes { get; set; }
        public class ListEnterpriseCodeResponseBodyEnterpriseCodes : TeaModel {
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("EnterpriseCode")]
            [Validation(Required=false)]
            public string EnterpriseCode { get; set; }

        }

    }

}
