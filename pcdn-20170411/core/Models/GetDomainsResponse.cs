// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetDomainsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetDomainsResponseDataList DataList { get; set; }
        public class GetDomainsResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetDomainsResponseDataListUsageData> UsageData { get; set; }
            public class GetDomainsResponseDataListUsageData : TeaModel {
                public string ResourceId { get; set; }
                public string Domain { get; set; }
                public string BusinessType { get; set; }
                public bool? Status { get; set; }
                public string CreatedAt { get; set; }
                public string UpdatedAt { get; set; }
                public string SliceFormat { get; set; }
            }
        };

        [NameInMap("Pager")]
        [Validation(Required=true)]
        public GetDomainsResponsePager Pager { get; set; }
        public class GetDomainsResponsePager : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=true)]
            public int? Page { get; set; }
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
        };

    }

}
