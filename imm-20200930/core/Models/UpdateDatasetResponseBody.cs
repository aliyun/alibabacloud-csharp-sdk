// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class UpdateDatasetResponseBody : TeaModel {
        [NameInMap("Dataset")]
        [Validation(Required=false)]
        public Dataset Dataset { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>45234D4A-A3E3-4B23-AACA-8D897514****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
