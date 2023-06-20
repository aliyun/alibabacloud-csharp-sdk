// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class CrossAccountVerifyTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CrossAccountVerifyTokenResponseBodyResult Result { get; set; }
        public class CrossAccountVerifyTokenResponseBodyResult : TeaModel {
            [NameInMap("AuthRoles")]
            [Validation(Required=false)]
            public List<string> AuthRoles { get; set; }

            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public long? AuthTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
