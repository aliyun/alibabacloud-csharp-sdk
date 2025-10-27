// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StopExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The reason for stopping the execution. The value must be 1 to 4,096 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for test</para>
        /// </summary>
        [NameInMap("Cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// <para>The error code for stopping the execution. The error code must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nill</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The name of the execution to be stopped. You can call the <b>ListExecutions</b> operation to obtain the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec</para>
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// <para>The name of the workflow to be stopped. You can call the <b>ListFlows</b> operation to obtain the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

    }

}
