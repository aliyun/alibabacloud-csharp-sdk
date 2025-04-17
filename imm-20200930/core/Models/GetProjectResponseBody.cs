// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The project information.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public Project Project { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A022F78-B9A8-4ACC-BB6B-B3597553</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
