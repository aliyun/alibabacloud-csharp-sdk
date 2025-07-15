// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAudioAuditConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of audio moderation configurations.</para>
        /// </summary>
        [NameInMap("LiveAudioAuditConfigList")]
        [Validation(Required=false)]
        public DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigList LiveAudioAuditConfigList { get; set; }
        public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigList : TeaModel {
            [NameInMap("LiveAudioAuditConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfig> LiveAudioAuditConfig { get; set; }
            public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfig : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The business type. You can specify a model. The default value is the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.edu</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The moderation scenarios.</para>
                /// </summary>
                [NameInMap("Scenes")]
                [Validation(Required=false)]
                public DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfigScenes Scenes { get; set; }
                public class DescribeLiveAudioAuditConfigResponseBodyLiveAudioAuditConfigListLiveAudioAuditConfigScenes : TeaModel {
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public List<string> Scene { get; set; }

                }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
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
