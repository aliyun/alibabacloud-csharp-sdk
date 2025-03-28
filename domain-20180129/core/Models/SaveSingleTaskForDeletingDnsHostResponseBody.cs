// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForDeletingDnsHostResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8fc97e44-837a-447d-ac61-ea28d2fe8a38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8fc97e44-837a-447d-ac61-ea28d2fexxxx</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
