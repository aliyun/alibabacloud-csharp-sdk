// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class AddDatasetDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("affectedRows")]
        [Validation(Required=false)]
        public int? AffectedRows { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0173835-9E0F-508F-8BFA-9F556E59C302</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
