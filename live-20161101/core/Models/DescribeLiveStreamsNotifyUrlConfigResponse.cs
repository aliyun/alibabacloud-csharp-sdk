// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsNotifyUrlConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamsNotifyConfig")]
        [Validation(Required=true)]
        public DescribeLiveStreamsNotifyUrlConfigResponseLiveStreamsNotifyConfig LiveStreamsNotifyConfig { get; set; }
        public class DescribeLiveStreamsNotifyUrlConfigResponseLiveStreamsNotifyConfig : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }
            [NameInMap("NotifyUrl")]
            [Validation(Required=true)]
            public string NotifyUrl { get; set; }
            [NameInMap("AuthType")]
            [Validation(Required=true)]
            public string AuthType { get; set; }
            [NameInMap("AuthKey")]
            [Validation(Required=true)]
            public string AuthKey { get; set; }
        };

    }

}
