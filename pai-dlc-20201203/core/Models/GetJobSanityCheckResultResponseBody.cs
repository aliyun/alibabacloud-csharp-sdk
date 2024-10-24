// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobSanityCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-xxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B3789344-F1xxxBE-5xx2-A04D-xxxxx</para>
        /// </summary>
        [NameInMap("RequestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        [NameInMap("SanityCheckResult")]
        [Validation(Required=false)]
        public List<SanityCheckResultItem> SanityCheckResult { get; set; }

    }

}
