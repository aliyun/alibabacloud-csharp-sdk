// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The project information. For more information, see Project.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public Project Project { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F7D235C-76FF-4B65-800C-8238AE3F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
