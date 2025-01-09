// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class DeleteAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2C5DAA30-****-5181-9B87-9D6181016197</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteAppResponseBodyResult Result { get; set; }
        public class DeleteAppResponseBodyResult : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
