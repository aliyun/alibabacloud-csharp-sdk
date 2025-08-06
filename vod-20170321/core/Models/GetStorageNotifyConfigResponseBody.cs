// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetStorageNotifyConfigResponseBody : TeaModel {
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("OssNotifyConfig")]
        [Validation(Required=false)]
        public GetStorageNotifyConfigResponseBodyOssNotifyConfig OssNotifyConfig { get; set; }
        public class GetStorageNotifyConfigResponseBodyOssNotifyConfig : TeaModel {
            [NameInMap("EventList")]
            [Validation(Required=false)]
            public string EventList { get; set; }

            [NameInMap("HttpProcessAddress")]
            [Validation(Required=false)]
            public string HttpProcessAddress { get; set; }

            [NameInMap("NotifyName")]
            [Validation(Required=false)]
            public string NotifyName { get; set; }

            [NameInMap("ResourcePrefixName")]
            [Validation(Required=false)]
            public string ResourcePrefixName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
