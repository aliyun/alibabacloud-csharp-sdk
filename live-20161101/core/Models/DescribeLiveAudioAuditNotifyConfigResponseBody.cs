// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditNotifyConfigResponseBody : TeaModel {
        [NameInMap("LiveAudioAuditNotifyConfigList")]
        [Validation(Required=false)]
        public DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigList LiveAudioAuditNotifyConfigList { get; set; }
        public class DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigList : TeaModel {
            [NameInMap("LiveAudioAuditNotifyConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig> LiveAudioAuditNotifyConfig { get; set; }
            public class DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig : TeaModel {
                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                [NameInMap("CallbackTemplate")]
                [Validation(Required=false)]
                public string CallbackTemplate { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B908FF89-B03C-4831-B55B-48D2A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
