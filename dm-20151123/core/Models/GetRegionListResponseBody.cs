// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetRegionListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRegionListResponseBodyData Data { get; set; }
        public class GetRegionListResponseBodyData : TeaModel {
            [NameInMap("regionList")]
            [Validation(Required=false)]
            public List<GetRegionListResponseBodyDataRegionList> RegionList { get; set; }
            public class GetRegionListResponseBodyDataRegionList : TeaModel {
                public string Region { get; set; }
                public string RegionDesc { get; set; }
            }
        };

    }

}
