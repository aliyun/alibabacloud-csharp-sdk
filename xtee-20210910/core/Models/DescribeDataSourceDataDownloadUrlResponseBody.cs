// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeDataSourceDataDownloadUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeDataSourceDataDownloadUrlResponseBodyResultObject ResultObject { get; set; }
        public class DescribeDataSourceDataDownloadUrlResponseBodyResultObject : TeaModel {
            [NameInMap("downloadFileUrl")]
            [Validation(Required=false)]
            public string DownloadFileUrl { get; set; }

        }

    }

}
