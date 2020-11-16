// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordNotifyConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveRecordNotifyConfig")]
        [Validation(Required=true)]
        public DescribeLiveRecordNotifyConfigResponseLiveRecordNotifyConfig LiveRecordNotifyConfig { get; set; }
        public class DescribeLiveRecordNotifyConfigResponseLiveRecordNotifyConfig : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }
            [NameInMap("NotifyUrl")]
            [Validation(Required=true)]
            public string NotifyUrl { get; set; }
            [NameInMap("OnDemandUrl")]
            [Validation(Required=true)]
            public string OnDemandUrl { get; set; }
            [NameInMap("NeedStatusNotify")]
            [Validation(Required=true)]
            public bool? NeedStatusNotify { get; set; }
        };

    }

}
