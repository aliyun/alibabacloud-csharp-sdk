// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetUserInfoResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetUserInfoResponseBodyResult Result { get; set; }
        public class GetUserInfoResponseBodyResult : TeaModel {
            [NameInMap("EnableCreateAppLimit")]
            [Validation(Required=false)]
            public bool? EnableCreateAppLimit { get; set; }
            [NameInMap("HasOrderedImp")]
            [Validation(Required=false)]
            public bool? HasOrderedImp { get; set; }
            [NameInMap("IsOverdue")]
            [Validation(Required=false)]
            public bool? IsOverdue { get; set; }
            [NameInMap("IsPayByWatchTimeLengthUser")]
            [Validation(Required=false)]
            public bool? IsPayByWatchTimeLengthUser { get; set; }
            [NameInMap("MaxCreateAppCount")]
            [Validation(Required=false)]
            public long? MaxCreateAppCount { get; set; }
        };

    }

}
