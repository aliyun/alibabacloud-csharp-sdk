// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StartWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mapping-gpu-66xv7</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

    }

}
