// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class Channel : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable access control.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AccessPolicy")]
        [Validation(Required=false)]
        public bool? AccessPolicy { get; set; }

        /// <summary>
        /// <para>The token for accessing the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The ARN of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ims:mediaweaver:<regionId>:<userId>:channel/myChannel</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>The name of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChannel</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>The tier of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("ChannelTier")]
        [Validation(Required=false)]
        public string ChannelTier { get; set; }

        /// <summary>
        /// <para>The source location of the filler slate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySourceLocation</para>
        /// </summary>
        [NameInMap("FillerSourceLocationName")]
        [Validation(Required=false)]
        public string FillerSourceLocationName { get; set; }

        /// <summary>
        /// <para>The source name of the filler slate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySource</para>
        /// </summary>
        [NameInMap("FillerSourceName")]
        [Validation(Required=false)]
        public string FillerSourceName { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-15T03:44:16Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-01T10:09Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The output configurations.</para>
        /// </summary>
        [NameInMap("OutPutConfigList")]
        [Validation(Required=false)]
        public List<ChannelOutPutConfigList> OutPutConfigList { get; set; }
        public class ChannelOutPutConfigList : TeaModel {
            /// <summary>
            /// <para>The name of the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyChannel</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>The format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hls</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The manifest name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>index1</para>
            /// </summary>
            [NameInMap("ManifestName")]
            [Validation(Required=false)]
            public string ManifestName { get; set; }

            /// <summary>
            /// <para>The manifest settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;WindowDuration&quot;: 60,&quot;AdMarkType&quot;:&quot;Daterange&quot;}</para>
            /// </summary>
            [NameInMap("ManifestSettings")]
            [Validation(Required=false)]
            public string ManifestSettings { get; set; }

            /// <summary>
            /// <para>The playback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxxx.com/xxx.m3u8">https://xxxxx.com/xxx.m3u8</a></para>
            /// </summary>
            [NameInMap("PlaybackUrl")]
            [Validation(Required=false)]
            public string PlaybackUrl { get; set; }

            /// <summary>
            /// <para>The name of the source group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("SourceGroupName")]
            [Validation(Required=false)]
            public string SourceGroupName { get; set; }

        }

        /// <summary>
        /// <para>The playback mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loop</para>
        /// </summary>
        [NameInMap("PlaybackMode")]
        [Validation(Required=false)]
        public string PlaybackMode { get; set; }

        /// <summary>
        /// <para>The state of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
