// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectNotifyConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveDetectNotifyConfig")]
        [Validation(Required=true)]
        public DescribeLiveDetectNotifyConfigResponseLiveDetectNotifyConfig LiveDetectNotifyConfig { get; set; }
        public class DescribeLiveDetectNotifyConfigResponseLiveDetectNotifyConfig : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }
            [NameInMap("NotifyUrl")]
            [Validation(Required=true)]
            public string NotifyUrl { get; set; }
        };

    }

}
