// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeRefreshQuotaResponseBody : TeaModel {
        [NameInMap("RefreshCacheQuota")]
        [Validation(Required=false)]
        public DescribeRefreshQuotaResponseBodyRefreshCacheQuota RefreshCacheQuota { get; set; }
        public class DescribeRefreshQuotaResponseBodyRefreshCacheQuota : TeaModel {
            [NameInMap("DirQuota")]
            [Validation(Required=false)]
            public string DirQuota { get; set; }

            [NameInMap("DirRemain")]
            [Validation(Required=false)]
            public string DirRemain { get; set; }

            [NameInMap("UrlQuota")]
            [Validation(Required=false)]
            public string UrlQuota { get; set; }

            [NameInMap("UrlRemain")]
            [Validation(Required=false)]
            public string UrlRemain { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
