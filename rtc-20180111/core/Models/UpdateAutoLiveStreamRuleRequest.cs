// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateAutoLiveStreamRuleRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query application IDs in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The callback URL for starting and stopping the bypass. You can query the bypass callback URL in the console or by calling the <a href="https://help.aliyun.com/document_detail/353198.html">DescribeAutoLiveStreamRule</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallBack")]
        [Validation(Required=false)]
        public string CallBack { get; set; }

        /// <summary>
        /// <para>The prefix list of channel IDs for fuzzy matching.</para>
        /// </summary>
        [NameInMap("ChannelIdPrefixes")]
        [Validation(Required=false)]
        public List<string> ChannelIdPrefixes { get; set; }

        /// <summary>
        /// <para>The list of channel IDs for exact matching.</para>
        /// </summary>
        [NameInMap("ChannelIds")]
        [Validation(Required=false)]
        public List<string> ChannelIds { get; set; }

        /// <summary>
        /// <para>The encoding options. For more information, see the valid values of MediaEncode in <a href="https://help.aliyun.com/document_detail/353179.html">CreateAutoLiveStreamRule</a>.</para>
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
        /// <para>The streaming domain name for automatic bypass. The streaming URL for an automatic bypass task is rtmp://${domain}/${app}/${stream}.</para>
        /// <list type="bullet">
        /// <item><description>domain: Your live streaming domain name.</description></item>
        /// <item><description>app: live.</description></item>
        /// <item><description>stream: urlencode(${AppId}<em>${ChannelId}</em>${UserId}_${SourceType}), where SourceType is the input source type.</description></item>
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
        /// <para>The ID of the bypass rule. You can query the bypass rule ID in the console or by calling the <a href="https://help.aliyun.com/document_detail/353198.html">DescribeAutoLiveStreamRule</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the bypass rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
