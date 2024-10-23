// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class JobConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxRetryTime")]
        [Validation(Required=false)]
        public int? MaxRetryTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("triggerInterval")]
        [Validation(Required=false)]
        public int? TriggerInterval { get; set; }

    }

}
