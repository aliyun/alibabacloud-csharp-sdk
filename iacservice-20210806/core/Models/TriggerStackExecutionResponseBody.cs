// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class TriggerStackExecutionResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2D40488-3F74-568B-87EC-1C04D098DF8B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>event-xxxx</para>
        /// </summary>
        [NameInMap("triggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

    }

}
