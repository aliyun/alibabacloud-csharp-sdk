// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetVhostErrorByTaskIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVhostErrorByTaskIdResponseBodyData Data { get; set; }
        public class GetVhostErrorByTaskIdResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public GetVhostErrorByTaskIdResponseBodyDataVoList VoList { get; set; }
            public class GetVhostErrorByTaskIdResponseBodyDataVoList : TeaModel {
                [NameInMap("VhostErrorDO")]
                [Validation(Required=false)]
                public List<GetVhostErrorByTaskIdResponseBodyDataVoListVhostErrorDO> VhostErrorDO { get; set; }
                public class GetVhostErrorByTaskIdResponseBodyDataVoListVhostErrorDO : TeaModel {
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public int? ErrorMessage { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("VhostName")]
                    [Validation(Required=false)]
                    public string VhostName { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
