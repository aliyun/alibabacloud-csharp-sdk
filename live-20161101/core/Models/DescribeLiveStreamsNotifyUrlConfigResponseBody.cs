// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsNotifyUrlConfigResponseBody : TeaModel {
        [NameInMap("LiveStreamsNotifyConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig LiveStreamsNotifyConfig { get; set; }
        public class DescribeLiveStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("NotifyAuthKey")]
            [Validation(Required=false)]
            public string NotifyAuthKey { get; set; }

            [NameInMap("NotifyReqAuth")]
            [Validation(Required=false)]
            public string NotifyReqAuth { get; set; }

            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
