// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>MyProject</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online_oral_evaluation_post_paid_call_count</para>
        /// </summary>
        [NameInMap("projectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

    }

}
