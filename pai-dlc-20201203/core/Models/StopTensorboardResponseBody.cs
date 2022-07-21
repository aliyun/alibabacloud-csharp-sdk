// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class StopTensorboardResponseBody : TeaModel {
        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Tensorboad Id
        /// </summary>
        [NameInMap("TensorboardId")]
        [Validation(Required=false)]
        public string TensorboardId { get; set; }

    }

}
