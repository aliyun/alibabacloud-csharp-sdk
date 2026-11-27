// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateAutoLiveStreamRuleRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be created and queried in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The callback URL used to notify the start and end of the relay. For details about the callback content, see the CallBack callback example below.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallBack")]
        [Validation(Required=false)]
        public string CallBack { get; set; }

        /// <summary>
        /// <para>The list of channel ID prefixes that are fuzzy matched.</para>
        /// </summary>
        [NameInMap("ChannelIdPrefixes")]
        [Validation(Required=false)]
        public List<string> ChannelIdPrefixes { get; set; }

        /// <summary>
        /// <para>The list of channel IDs that are exactly matched.</para>
        /// </summary>
        [NameInMap("ChannelIds")]
        [Validation(Required=false)]
        public List<string> ChannelIds { get; set; }

        /// <summary>
        /// <para>The encoding option. For more information, see the MediaEncode enumeration values below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The streaming domain name for automatic relay. The streaming URL of an automatic relay task is in the format rtmp://${domain}/${app}/${stream}.</para>
        /// <list type="bullet">
        /// <item><description>domain: your live streaming domain name.</description></item>
        /// <item><description>app: live.</description></item>
        /// <item><description>stream: urlencode(${AppId}<em>${ChannelId}</em>${UserId}_${SourceType}), where SourceType indicates the type of the input source.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://${domain}/${app}/${stream}</para>
        /// </summary>
        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// <para>The name of the relay rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
