// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class UpdateProjectRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The new name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyProject</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
