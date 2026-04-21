// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class ExpendExpiredTimeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>280451935746041600</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025:02:24 00:00:00</para>
        /// </summary>
        [NameInMap("testStartTime")]
        [Validation(Required=false)]
        public string TestStartTime { get; set; }

    }

}
