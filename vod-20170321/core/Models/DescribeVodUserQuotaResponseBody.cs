// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserQuotaResponseBody : TeaModel {
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public int? BlockQuota { get; set; }

        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public int? BlockRemain { get; set; }

        [NameInMap("DomainQuota")]
        [Validation(Required=false)]
        public int? DomainQuota { get; set; }

        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public int? PreloadQuota { get; set; }

        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public int? PreloadRemain { get; set; }

        [NameInMap("RefreshDirQuota")]
        [Validation(Required=false)]
        public int? RefreshDirQuota { get; set; }

        [NameInMap("RefreshDirRemain")]
        [Validation(Required=false)]
        public int? RefreshDirRemain { get; set; }

        [NameInMap("RefreshUrlQuota")]
        [Validation(Required=false)]
        public int? RefreshUrlQuota { get; set; }

        [NameInMap("RefreshUrlRemain")]
        [Validation(Required=false)]
        public int? RefreshUrlRemain { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
