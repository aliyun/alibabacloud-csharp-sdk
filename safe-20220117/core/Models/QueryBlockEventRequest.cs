// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class QueryBlockEventRequest : TeaModel {
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("BgSystemName")]
        [Validation(Required=false)]
        public string BgSystemName { get; set; }

        [NameInMap("BlockHarm")]
        [Validation(Required=false)]
        public string BlockHarm { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("DeptNo")]
        [Validation(Required=false)]
        public string DeptNo { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("NeedRule")]
        [Validation(Required=false)]
        public bool? NeedRule { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("ProductCodes")]
        [Validation(Required=false)]
        public List<string> ProductCodes { get; set; }

        [NameInMap("RegionReqs")]
        [Validation(Required=false)]
        public List<QueryBlockEventRequestRegionReqs> RegionReqs { get; set; }
        public class QueryBlockEventRequestRegionReqs : TeaModel {
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<string> Regions { get; set; }

        }

        [NameInMap("ReqTimestamp")]
        [Validation(Required=false)]
        public long? ReqTimestamp { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public List<string> Scope { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
