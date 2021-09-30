// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetClassDetailResponseBody : TeaModel {
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
        public GetClassDetailResponseBodyResult Result { get; set; }
        public class GetClassDetailResponseBodyResult : TeaModel {
            [NameInMap("ClassId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }
            [NameInMap("CreateNickname")]
            [Validation(Required=false)]
            public string CreateNickname { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
        };

    }

}
