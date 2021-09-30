// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateClassResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// API请求的返回结果结构体。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateClassResponseBodyResult Result { get; set; }
        public class CreateClassResponseBodyResult : TeaModel {
            [NameInMap("ClassId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }
        };

    }

}
