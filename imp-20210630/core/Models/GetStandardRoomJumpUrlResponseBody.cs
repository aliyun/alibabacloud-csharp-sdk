// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetStandardRoomJumpUrlResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetStandardRoomJumpUrlResponseBodyResult Result { get; set; }
        public class GetStandardRoomJumpUrlResponseBodyResult : TeaModel {
            [NameInMap("StandardRoomJumpUrl")]
            [Validation(Required=false)]
            public string StandardRoomJumpUrl { get; set; }
        };

    }

}
