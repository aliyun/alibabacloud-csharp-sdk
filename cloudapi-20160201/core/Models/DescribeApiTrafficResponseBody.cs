// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribeApiTrafficResponseBody : TeaModel {
        [NameInMap("Downloads")]
        [Validation(Required=false)]
        public DescribeApiTrafficResponseBodyDownloads Downloads { get; set; }
        public class DescribeApiTrafficResponseBodyDownloads : TeaModel {
            [NameInMap("Download")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficResponseBodyDownloadsDownload> Download { get; set; }
            public class DescribeApiTrafficResponseBodyDownloadsDownload : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Uploads")]
        [Validation(Required=false)]
        public DescribeApiTrafficResponseBodyUploads Uploads { get; set; }
        public class DescribeApiTrafficResponseBodyUploads : TeaModel {
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficResponseBodyUploadsUpload> Upload { get; set; }
            public class DescribeApiTrafficResponseBodyUploadsUpload : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
