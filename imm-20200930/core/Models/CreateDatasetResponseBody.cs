// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateDatasetResponseBody : TeaModel {
        /// <summary>
        /// 请求 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Dataset")]
        [Validation(Required=false)]
        public Dataset Dataset { get; set; }

    }

}
