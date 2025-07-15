// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamWatermarkRuleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the watermark rule.</para>
        /// <remarks>
        /// <para> You can obtain the rule ID by checking the value of the RuleId parameter that is returned by the <a href="https://help.aliyun.com/document_detail/2848100.html">AddLiveStreamWatermarkRule</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d -8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the stream. The following matching rules apply:</para>
        /// <list type="bullet">
        /// <item><description>A stream name can be exactly matched, Example: liveStreamA.</description></item>
        /// <item><description>Fuzzy match is also supported. The use of an asterisk (<c>*</c>) allows all approximate matches to be found.</description></item>
        /// <item><description>You can place the asterisk before or after an approximate string.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Fuzzy match: Only one asterisk (<c>*</c>) before or after an approximate string is allowed. The approximate string must be enclosed in <c>()</c>. Separate multiple strings with vertical bars (<c>|</c>).</para>
        /// </description></item>
        /// <item><description><para>For example, <c>*(t1|t2)</c> matches all streams whose name has the <c>t1</c> or <c>t2</c> suffix, and <c>(abc|123)*</c> matches all streams whose name has the <c>abc</c> or <c>123</c> prefix.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>liveStreamA</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
