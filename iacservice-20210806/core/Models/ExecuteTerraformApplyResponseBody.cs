// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ExecuteTerraformApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C896FE0A-1BEA-5D01-BFF4-B03B82B9CA3D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task-xxxx</para>
        /// </summary>
        [NameInMap("stateId")]
        [Validation(Required=false)]
        public string StateId { get; set; }

    }

}
