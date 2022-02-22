// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateEciConfigResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// errMsg
        /// </summary>
        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateEciConfigResponseBodyResult Result { get; set; }
        public class CreateEciConfigResponseBodyResult : TeaModel {
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
        };

    }

}
