// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditNotifyConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveAudioAuditNotifyConfigList")]
        [Validation(Required=true)]
        public DescribeLiveAudioAuditNotifyConfigResponseLiveAudioAuditNotifyConfigList LiveAudioAuditNotifyConfigList { get; set; }
        public class DescribeLiveAudioAuditNotifyConfigResponseLiveAudioAuditNotifyConfigList : TeaModel {
            [NameInMap("LiveAudioAuditNotifyConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveAudioAuditNotifyConfigResponseLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig> LiveAudioAuditNotifyConfig { get; set; }
            public class DescribeLiveAudioAuditNotifyConfigResponseLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig : TeaModel {
                public string DomainName { get; set; }
                public string Callback { get; set; }
                public string CallbackTemplate { get; set; }
            }
        };

    }

}
