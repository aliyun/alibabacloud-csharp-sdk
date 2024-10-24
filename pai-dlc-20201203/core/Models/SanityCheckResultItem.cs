// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SanityCheckResultItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckNumber")]
        [Validation(Required=false)]
        public int? CheckNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”2023-11-30T16:47:30.378817+08:00&quot;</para>
        /// </summary>
        [NameInMap("FinishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CheckInit</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”2023-11-30T16:47:30.343005+08:00“</para>
        /// </summary>
        [NameInMap("StartedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
