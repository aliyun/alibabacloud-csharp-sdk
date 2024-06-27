// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAppKeyPageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAppKeyPageResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAppKeyPageResponseBodyResultObject : TeaModel {
            [NameInMap("androidSdkUrl")]
            [Validation(Required=false)]
            public string AndroidSdkUrl { get; set; }

            [NameInMap("androidSdkVersion")]
            [Validation(Required=false)]
            public string AndroidSdkVersion { get; set; }

            [NameInMap("appKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("iosSdkUrl")]
            [Validation(Required=false)]
            public string IosSdkUrl { get; set; }

            [NameInMap("iosSdkVersion")]
            [Validation(Required=false)]
            public string IosSdkVersion { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("sdkItems")]
            [Validation(Required=false)]
            public string SdkItems { get; set; }

            [NameInMap("used")]
            [Validation(Required=false)]
            public string Used { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
