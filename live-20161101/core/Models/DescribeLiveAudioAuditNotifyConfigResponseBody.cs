// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditNotifyConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of callbacks for audio moderation results.</para>
        /// </summary>
        [NameInMap("LiveAudioAuditNotifyConfigList")]
        [Validation(Required=false)]
        public DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigList LiveAudioAuditNotifyConfigList { get; set; }
        public class DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigList : TeaModel {
            [NameInMap("LiveAudioAuditNotifyConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig> LiveAudioAuditNotifyConfig { get; set; }
            public class DescribeLiveAudioAuditNotifyConfigResponseBodyLiveAudioAuditNotifyConfigListLiveAudioAuditNotifyConfig : TeaModel {
                /// <summary>
                /// <para>The callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://guide.aliyundoc.com/callback">http://guide.aliyundoc.com/callback</a></para>
                /// </summary>
                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                /// <summary>
                /// <para>The callback template. The following fields are configured:</para>
                /// <list type="bullet">
                /// <item><description><b>{DomainName}</b>: the streaming domain.</description></item>
                /// <item><description><b>{AppName}</b>: the name of the application to which the live stream belongs.</description></item>
                /// <item><description><b>{StreamName}</b>: the name of the live stream.</description></item>
                /// <item><description><b>{Timestamp}</b>: the time when the callback is returned. The value of this field is a UNIX timestamp. Unit: seconds.</description></item>
                /// <item><description><b>{Result}</b>: the moderation results.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;domain\&quot;:{DomainName},\&quot;app\&quot;:{AppName},\&quot;stream\&quot;:{StreamName},\&quot;timestamp\&quot;:{Timestamp},\&quot;result\&quot;:{Result}}</para>
                /// </summary>
                [NameInMap("CallbackTemplate")]
                [Validation(Required=false)]
                public string CallbackTemplate { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
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
