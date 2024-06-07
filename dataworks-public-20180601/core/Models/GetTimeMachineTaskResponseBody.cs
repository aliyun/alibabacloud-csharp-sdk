// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class GetTimeMachineTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTimeMachineTaskResponseBodyData Data { get; set; }
        public class GetTimeMachineTaskResponseBodyData : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ObjId")]
            [Validation(Required=false)]
            public string ObjId { get; set; }

            [NameInMap("ObjName")]
            [Validation(Required=false)]
            public string ObjName { get; set; }

            [NameInMap("OperType")]
            [Validation(Required=false)]
            public string OperType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
