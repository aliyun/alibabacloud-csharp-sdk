// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditNotifyConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveAudioAuditNotifyConfigList")]
        [Validation(Required=false)]
        public DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigList LiveAudioAuditNotifyConfigList { get; set; }
        public class DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigList : TeaModel {
            [NameInMap("LiveAudioAuditNotifyConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig> LiveAudioAuditNotifyConfig { get; set; }
            public class DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig : TeaModel {
                public string CallbackTemplate { get; set; }
                public string DomainName { get; set; }
                public string Callback { get; set; }
            }
        };

    }

}
