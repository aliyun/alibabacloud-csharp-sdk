// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class MemberPointChangeResponseBody : TeaModel {
        [NameInMap("AccountBalance")]
        [Validation(Required=false)]
        public string AccountBalance { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LevelName")]
        [Validation(Required=false)]
        public string LevelName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
