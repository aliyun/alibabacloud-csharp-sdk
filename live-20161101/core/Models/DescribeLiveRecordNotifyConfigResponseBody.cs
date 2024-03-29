// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordNotifyConfigResponseBody : TeaModel {
        [NameInMap("LiveRecordNotifyConfig")]
        [Validation(Required=false)]
        public DescribeLiveRecordNotifyConfigResponseBodyLiveRecordNotifyConfig LiveRecordNotifyConfig { get; set; }
        public class DescribeLiveRecordNotifyConfigResponseBodyLiveRecordNotifyConfig : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("NeedStatusNotify")]
            [Validation(Required=false)]
            public bool? NeedStatusNotify { get; set; }

            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

            [NameInMap("OnDemandUrl")]
            [Validation(Required=false)]
            public string OnDemandUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
