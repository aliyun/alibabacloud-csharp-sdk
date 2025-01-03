// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CreateExperimentPlanTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("PrivacyLevel")]
        [Validation(Required=false)]
        public string PrivacyLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The template installs jdk and tomcat on a new ECS instance.</para>
        /// </summary>
        [NameInMap("TemplateDescription")]
        [Validation(Required=false)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4724</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplatePipeline")]
        [Validation(Required=false)]
        public string TemplatePipelineShrink { get; set; }

    }

}
