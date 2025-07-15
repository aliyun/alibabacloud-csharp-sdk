// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamWatermarkRuleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>A stream name can be exactly matched. Example: liveStreamA.</description></item>
        /// <item><description>Fuzzy match is also supported. The use of an asterisk (<c>*</c>) allows all approximate matches to be found.</description></item>
        /// <item><description>You can place the asterisk before or after an approximate string.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Fuzzy match: Only one asterisk (<c>*</c>) before or after an approximate string is allowed. The approximate string must be enclosed in <c>()</c>. Separate multiple strings with vertical bars (<c>|</c>).</description></item>
        /// <item><description>For example, <c>*(t1|t2)</c> matches all streams whose name has the <c>t1</c> or <c>t2</c> suffix, and <c>(abc|123)*</c> matches all streams whose name has the <c>abc</c> or <c>123</c> prefix.</description></item>
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
        /// <para> You can obtain the template ID by checking the value of the TemplateId parameter that is returned by the <a href="https://help.aliyun.com/document_detail/410759.html">AddLiveStreamWatermark</a> operation.</para>
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
