// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFileVersionResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileVersionResponseBodyData Data { get; set; }
        public class GetFileVersionResponseBodyData : TeaModel {
            [NameInMap("FileContent")]
            [Validation(Required=false)]
            public string FileContent { get; set; }
            [NameInMap("IsCurrentProd")]
            [Validation(Required=false)]
            public bool? IsCurrentProd { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("NodeContent")]
            [Validation(Required=false)]
            public string NodeContent { get; set; }
            [NameInMap("CommitUser")]
            [Validation(Required=false)]
            public string CommitUser { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("FilePropertyContent")]
            [Validation(Required=false)]
            public string FilePropertyContent { get; set; }
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("UseType")]
            [Validation(Required=false)]
            public string UseType { get; set; }
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }
            [NameInMap("FileVersion")]
            [Validation(Required=false)]
            public int? FileVersion { get; set; }
            [NameInMap("CommitTime")]
            [Validation(Required=false)]
            public long? CommitTime { get; set; }
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }
        };

    }

}
