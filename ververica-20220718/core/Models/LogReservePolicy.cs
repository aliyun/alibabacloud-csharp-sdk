// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class LogReservePolicy : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("expirationDays")]
        [Validation(Required=false)]
        public long? ExpirationDays { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("openHistory")]
        [Validation(Required=false)]
        public bool? OpenHistory { get; set; }

    }

}
