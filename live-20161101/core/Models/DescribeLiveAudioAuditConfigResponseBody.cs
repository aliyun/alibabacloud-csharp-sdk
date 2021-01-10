// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveAudioAuditConfigList")]
        [Validation(Required=false)]
        public DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigList LiveAudioAuditConfigList { get; set; }
        public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigList : TeaModel {
            [NameInMap("LiveAudioAuditConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfig> LiveAudioAuditConfig { get; set; }
            public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfig : TeaModel {
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfigScenes Scenes { get; set; }
                public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfigScenes : TeaModel {
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public List<string> Scene { get; set; }

                }
                public string DomainName { get; set; }
                public string BizType { get; set; }
            }
        };

    }

}
