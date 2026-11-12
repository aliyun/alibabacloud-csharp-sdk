// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateBenchmarkTaskRequest : TeaModel {
        /// <summary>
        /// <para>The configuration parameters of the stress testing task. For more information, see <b>Table 1. base description table</b>. The target stress testing task must be in the Running state. You can call the DescribeBenchmarkTask operation to query the task status. If the task is in the Stopped state, you must first call the StartBenchmarkTask operation and wait until the task enters the Running state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;base&quot;:  {
        ///          &quot;qps&quot;: 200
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
