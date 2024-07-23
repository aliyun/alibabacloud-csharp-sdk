// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobStatusRunning : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("observedFlinkJobRestarts")]
        [Validation(Required=false)]
        public long? ObservedFlinkJobRestarts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("observedFlinkJobStatus")]
        [Validation(Required=false)]
        public string ObservedFlinkJobStatus { get; set; }

    }

}
