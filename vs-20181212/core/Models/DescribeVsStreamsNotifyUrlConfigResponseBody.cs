// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsNotifyUrlConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamsNotifyConfig")]
        [Validation(Required=false)]
        public DescribeVsStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig LiveStreamsNotifyConfig { get; set; }
        public class DescribeVsStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig : TeaModel {
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
        };

    }

}
