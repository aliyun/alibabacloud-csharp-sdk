// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SubmitMaterialTaskRequest : TeaModel {
        /// <summary>
        /// <para>Job parameters</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;brandName&quot;: &quot;品牌名称&quot;,
        ///     &quot;direction&quot;: &quot;HORIZONTAL&quot;,
        ///     &quot;userPrompt&quot;: &quot;设计要求&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>Task Type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_LOGO</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
