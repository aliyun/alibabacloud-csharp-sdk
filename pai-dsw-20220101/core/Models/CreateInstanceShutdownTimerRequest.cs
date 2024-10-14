// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateInstanceShutdownTimerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("DueTime")]
        [Validation(Required=false)]
        public string DueTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600000</para>
        /// </summary>
        [NameInMap("RemainingTimeInMs")]
        [Validation(Required=false)]
        public long? RemainingTimeInMs { get; set; }

    }

}
