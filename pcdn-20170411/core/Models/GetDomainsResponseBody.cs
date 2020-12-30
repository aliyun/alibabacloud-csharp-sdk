// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetDomainsResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetDomainsResponseBodyDataList DataList { get; set; }
        public class GetDomainsResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetDomainsResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetDomainsResponseBodyDataListUsageData : TeaModel {
                public bool? Status { get; set; }
                public string Domain { get; set; }
                public string SliceFormat { get; set; }
                public string CreatedAt { get; set; }
                public string UpdatedAt { get; set; }
                public string ResourceId { get; set; }
                public string BusinessType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Pager")]
        [Validation(Required=false)]
        public GetDomainsResponseBodyPager Pager { get; set; }
        public class GetDomainsResponseBodyPager : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
