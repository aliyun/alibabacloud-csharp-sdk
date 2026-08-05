// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamWatermarkRuleRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the watermark rule.</para>
        /// <remarks>
        /// <para>Get this ID from the response of the <a href="https://help.aliyun.com/document_detail/2848100.html">AddLiveStreamWatermarkRule</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d -8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The stream name. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description><para>To match a specific stream, enter the full stream name. Example: liveStreamA.</para>
        /// </description></item>
        /// <item><description><para>Use a wildcard for matching. The asterisk (\*) matches all streams.</para>
        /// </description></item>
        /// <item><description><para>You can match by prefix or suffix.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For wildcard matching, use only one asterisk (\*) at the beginning or end of the string. Enclose matching items in parentheses. Separate multiple matching items with a vertical bar (|).</para>
        /// </description></item>
        /// <item><description><para>Example: <c>*(t1|t2)</c> matches all streams ending with <c>t1</c> or <c>t2</c>. <c>(abc|123)*</c> matches all streams starting with <c>abc</c> or <c>123</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveStreamA</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
