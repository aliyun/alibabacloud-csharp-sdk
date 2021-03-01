// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryMigrateRegionListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("RegionEntityList")]
        [Validation(Required=false)]
        public QueryMigrateRegionListResponseBodyRegionEntityList RegionEntityList { get; set; }
        public class QueryMigrateRegionListResponseBodyRegionEntityList : TeaModel {
            [NameInMap("RegionEntity")]
            [Validation(Required=false)]
            public List<QueryMigrateRegionListResponseBodyRegionEntityListRegionEntity> RegionEntity { get; set; }
            public class QueryMigrateRegionListResponseBodyRegionEntityListRegionEntity : TeaModel {
                public string RegionName { get; set; }
                public string RegionNo { get; set; }
            }
        };

    }

}
