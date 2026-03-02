// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SavepointFailure : TeaModel {
        /// <summary>
        /// <para>The time when the deployment fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1655006835</para>
        /// </summary>
        [NameInMap("failedAt")]
        [Validation(Required=false)]
        public long? FailedAt { get; set; }

        /// <summary>
        /// <para>The failure information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create savepoint failed</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The reason for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IO Exception</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
