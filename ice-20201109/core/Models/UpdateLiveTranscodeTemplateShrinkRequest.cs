// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveTranscodeTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The template name.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration of the template.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfigShrink { get; set; }

        /// <summary>
        /// <para>The template ID. To obtain the template ID, log on to the <a href="https://ims.console.aliyun.com/summary">Intelligent Media Services (IMS) console</a>, choose Real-time Media Processing &gt; Template Management, and then click the Transcoding tab. Alternatively, find the ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/449217.html">CreateLiveTranscodeTemplate</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
