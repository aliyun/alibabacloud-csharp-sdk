// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsNotifyUrlConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamsNotifyConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig LiveStreamsNotifyConfig { get; set; }
        public class DescribeLiveStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig : TeaModel {
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
        };

    }

}
