// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartWorkflowRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Type&quot;: &quot;Media&quot;,
        ///       &quot;Media&quot;: &quot;<b><b><b>30706071edbfe290b488</b></b></b>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskInput")]
        [Validation(Required=false)]
        public string TaskInput { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>f0e54971ecbffd472190</b></b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
