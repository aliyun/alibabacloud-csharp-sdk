// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshQuotaResponseBody : TeaModel {
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public string PreloadRemain { get; set; }

        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public string BlockRemain { get; set; }

        [NameInMap("RegexRemain")]
        [Validation(Required=false)]
        public string RegexRemain { get; set; }

        [NameInMap("UrlRemain")]
        [Validation(Required=false)]
        public string UrlRemain { get; set; }

        [NameInMap("DirRemain")]
        [Validation(Required=false)]
        public string DirRemain { get; set; }

        [NameInMap("UrlQuota")]
        [Validation(Required=false)]
        public string UrlQuota { get; set; }

        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public string BlockQuota { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DirQuota")]
        [Validation(Required=false)]
        public string DirQuota { get; set; }

        [NameInMap("PreloadEdgeQuota")]
        [Validation(Required=false)]
        public string PreloadEdgeQuota { get; set; }

        [NameInMap("PreloadEdgeRemain")]
        [Validation(Required=false)]
        public string PreloadEdgeRemain { get; set; }

        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public string PreloadQuota { get; set; }

        [NameInMap("RegexQuota")]
        [Validation(Required=false)]
        public string RegexQuota { get; set; }

    }

}
