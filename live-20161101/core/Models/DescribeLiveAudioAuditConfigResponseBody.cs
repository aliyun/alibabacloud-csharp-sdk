// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditConfigResponseBody : TeaModel {
        [NameInMap("LiveAudioAuditConfigList")]
        [Validation(Required=false)]
        public DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigList LiveAudioAuditConfigList { get; set; }
        public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigList : TeaModel {
            [NameInMap("LiveAudioAuditConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfig> LiveAudioAuditConfig { get; set; }
            public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfig : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Scenes")]
                [Validation(Required=false)]
                public DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfigScenes Scenes { get; set; }
                public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfigScenes : TeaModel {
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public List<string> Scene { get; set; }

                }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BF95F2A-3B24-4CDE-9346-7F6FA86697A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
