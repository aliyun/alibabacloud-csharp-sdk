// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetRoomStatisticsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRoomStatisticsResponseBodyResult Result { get; set; }
        public class GetRoomStatisticsResponseBodyResult : TeaModel {
            [NameInMap("OnlineCount")]
            [Validation(Required=false)]
            public int? OnlineCount { get; set; }

            [NameInMap("PV")]
            [Validation(Required=false)]
            public int? PV { get; set; }

            [NameInMap("UV")]
            [Validation(Required=false)]
            public int? UV { get; set; }

        }

    }

}
