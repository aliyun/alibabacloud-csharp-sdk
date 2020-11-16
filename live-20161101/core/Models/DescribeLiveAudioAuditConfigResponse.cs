// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveAudioAuditConfigList")]
        [Validation(Required=true)]
        public DescribeLiveAudioAuditConfigResponseLiveAudioAuditConfigList LiveAudioAuditConfigList { get; set; }
        public class DescribeLiveAudioAuditConfigResponseLiveAudioAuditConfigList : TeaModel {
            [NameInMap("LiveAudioAuditConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveAudioAuditConfigResponseLiveAudioAuditConfigListLiveAudioAuditConfig> LiveAudioAuditConfig { get; set; }
            public class DescribeLiveAudioAuditConfigResponseLiveAudioAuditConfigListLiveAudioAuditConfig : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string BizType { get; set; }
                public DescribeLiveAudioAuditConfigResponseLiveAudioAuditConfigListLiveAudioAuditConfigScenes Scenes { get; set; }
                public class DescribeLiveAudioAuditConfigResponseLiveAudioAuditConfigListLiveAudioAuditConfigScenes : TeaModel {
                    /// <summary>
                    /// scene
                    /// </summary>
                    [NameInMap("scene")]
                    [Validation(Required=true)]
                    public List<string> Scene { get; set; }

                }
            }
        };

    }

}
