// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetIpfilterListResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIpfilterListResponseBodyData Data { get; set; }
        public class GetIpfilterListResponseBodyData : TeaModel {
            [NameInMap("ipfilters")]
            [Validation(Required=false)]
            public List<GetIpfilterListResponseBodyDataIpfilters> Ipfilters { get; set; }
            public class GetIpfilterListResponseBodyDataIpfilters : TeaModel {
                public string CreateTime { get; set; }
                public string Id { get; set; }
                public string IpAddress { get; set; }
            }
        };

    }

}
