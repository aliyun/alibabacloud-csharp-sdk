// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSDKDownloadListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSDKDownloadListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSDKDownloadListResponseBodyResultObject : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("developer")]
            [Validation(Required=false)]
            public string Developer { get; set; }

            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("packageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            [NameInMap("privacyLink")]
            [Validation(Required=false)]
            public string PrivacyLink { get; set; }

            [NameInMap("pushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            [NameInMap("sdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

    }

}
