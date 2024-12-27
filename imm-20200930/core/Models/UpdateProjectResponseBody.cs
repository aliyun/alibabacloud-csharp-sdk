// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class UpdateProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The project. For more information, see &quot;Project&quot;.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public Project Project { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D33C3574-4093-448E-86E7-15BE2BD3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
