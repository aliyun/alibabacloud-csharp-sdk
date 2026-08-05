// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamWatermarkRuleRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The description of the custom rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my rule</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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

        /// <summary>
        /// <para>The name of the custom rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WatermarkRule****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The stream name. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description><para>To match a specific stream, enter the full stream name. For example, liveStreamA.</para>
        /// </description></item>
        /// <item><description><para>You can use a wildcard match. The asterisk (<c>*</c>) matches all streams.</para>
        /// </description></item>
        /// <item><description><para>You can perform prefix and suffix matching.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can use only one asterisk (<c>*</c>). The asterisk must be at the beginning or end of the string. The matching items must be enclosed in parentheses (<c>()</c>) and separated by a vertical bar (<c>|</c>).</para>
        /// </description></item>
        /// <item><description><para>For example, <c>*(t1|t2)</c> matches all streams that end with <c>t1</c> or <c>t2</c>. <c>(abc|123)*</c> matches all streams that start with <c>abc</c> or <c>123</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStreamA</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

        /// <summary>
        /// <para>The ID of the watermark template.</para>
        /// <remarks>
        /// <para>Get the template ID from the response of the <a href="https://help.aliyun.com/document_detail/2848096.html">AddLiveStreamWatermark</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
