// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecDataCheckRunFailedRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID returned by the ExecDataCheckSaveTask operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20001</para>
        /// </summary>
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// <para>The rerun type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Reruns only execution-failed subtasks.</description></item>
        /// <item><description>1: Reruns execution-failed and validation-failed subtasks.</description></item>
        /// <item><description>2: Reruns execution-failed and stopped subtasks.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
