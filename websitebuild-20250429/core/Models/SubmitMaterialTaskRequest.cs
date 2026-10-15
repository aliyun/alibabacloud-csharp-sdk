// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SubmitMaterialTaskRequest : TeaModel {
        /// <summary>
        /// <para>The business group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("BizGroupId")]
        [Validation(Required=false)]
        public string BizGroupId { get; set; }

        /// <summary>
        /// <para>The task parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;brandName&quot;: &quot;Brand name&quot;,
        ///     &quot;direction&quot;: &quot;HORIZONTAL&quot;,
        ///     &quot;userPrompt&quot;: &quot;Design requirements&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The task type.</para>
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
