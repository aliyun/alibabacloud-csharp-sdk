// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class UpdateJobTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The template configuration.</para>
        /// </summary>
        [NameInMap("JobTemplateConfig")]
        [Validation(Required=false)]
        public string JobTemplateConfigShrink { get; set; }

        /// <summary>
        /// <para>The template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("JobTemplateDescription")]
        [Validation(Required=false)]
        public string JobTemplateDescription { get; set; }

        /// <summary>
        /// <para>The job template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jt-xxxx</para>
        /// </summary>
        [NameInMap("JobTemplateId")]
        [Validation(Required=false)]
        public string JobTemplateId { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-template</para>
        /// </summary>
        [NameInMap("JobTemplateName")]
        [Validation(Required=false)]
        public string JobTemplateName { get; set; }

    }

}
