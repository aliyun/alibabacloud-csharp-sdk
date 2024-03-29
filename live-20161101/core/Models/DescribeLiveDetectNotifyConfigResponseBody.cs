// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectNotifyConfigResponseBody : TeaModel {
        [NameInMap("LiveDetectNotifyConfig")]
        [Validation(Required=false)]
        public DescribeLiveDetectNotifyConfigResponseBodyLiveDetectNotifyConfig LiveDetectNotifyConfig { get; set; }
        public class DescribeLiveDetectNotifyConfigResponseBodyLiveDetectNotifyConfig : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
