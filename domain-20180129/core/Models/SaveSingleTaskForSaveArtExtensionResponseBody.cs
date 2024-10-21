// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForSaveArtExtensionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E2598CAF-DBFE-494E-95EF-B42A33C178AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e893148f-6343-4ae1-9eba-6e2a4116e141</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
