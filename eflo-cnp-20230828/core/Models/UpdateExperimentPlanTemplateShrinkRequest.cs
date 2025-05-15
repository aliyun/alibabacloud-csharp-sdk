// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class UpdateExperimentPlanTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Template code</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>349623</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>Template pipeline</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplatePipeline")]
        [Validation(Required=false)]
        public string TemplatePipelineShrink { get; set; }

    }

}
