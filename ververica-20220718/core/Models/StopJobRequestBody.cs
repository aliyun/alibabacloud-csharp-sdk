// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StopJobRequestBody : TeaModel {
        /// <summary>
        /// <para>The strategy that is used to stop a job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>NONE</c>: Directly stop the job.</description></item>
        /// <item><description><c>STOP_WITH_SAVEPOINT</c>: Stop the job after a savepoint is generated.</description></item>
        /// <item><description><c>STOP_WITH_DRAIN</c>: Stop the job and drain the pipeline. Use this strategy only if you want to permanently terminate the job.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("stopStrategy")]
        [Validation(Required=false)]
        public string StopStrategy { get; set; }

    }

}
