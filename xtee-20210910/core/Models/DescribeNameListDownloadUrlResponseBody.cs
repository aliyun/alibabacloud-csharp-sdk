// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeNameListDownloadUrlResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeNameListDownloadUrlResponseBodyResultObject ResultObject { get; set; }
        public class DescribeNameListDownloadUrlResponseBodyResultObject : TeaModel {
            [NameInMap("downloadFileUrl")]
            [Validation(Required=false)]
            public string DownloadFileUrl { get; set; }

        }

    }

}
