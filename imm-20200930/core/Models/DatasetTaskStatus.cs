// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DatasetTaskStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("LastSucceededTime")]
        [Validation(Required=false)]
        public string LastSucceededTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
