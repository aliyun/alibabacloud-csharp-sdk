// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateJobTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the template.</para>
        /// </summary>
        [NameInMap("JobTemplateConfig")]
        [Validation(Required=false)]
        public string JobTemplateConfigShrink { get; set; }

        /// <summary>
        /// <para>The description of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("JobTemplateDescription")]
        [Validation(Required=false)]
        public string JobTemplateDescription { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-template</para>
        /// </summary>
        [NameInMap("JobTemplateName")]
        [Validation(Required=false)]
        public string JobTemplateName { get; set; }

    }

}
