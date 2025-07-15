// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveStreamWatermarkRuleRequest : TeaModel {
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
        /// <para>The name of the custom rule.</para>
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
        /// <para>The ID of the watermark rule.</para>
        /// <remarks>
        /// <para> You can obtain the rule ID by checking the value of the RuleId parameter that is returned by the <a href="https://help.aliyun.com/document_detail/2848100.html">AddLiveStreamWatermarkRule</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The ID of the watermark template.</para>
        /// <remarks>
        /// <para> You can obtain the template ID by checking the value of the TemplateId parameter that is returned by the <a href="https://help.aliyun.com/document_detail/2848096.html">AddLiveStreamWatermark</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9 ****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
