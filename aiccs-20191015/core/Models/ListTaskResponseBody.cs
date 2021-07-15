// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListTaskResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskResponseBodyData Data { get; set; }
        public class ListTaskResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<ListTaskResponseBodyDataRecord> Record { get; set; }
            public class ListTaskResponseBodyDataRecord : TeaModel {
                public string Status { get; set; }
                public string GmtCreate { get; set; }
                public int? TotalCount { get; set; }
                public string FireTime { get; set; }
                public string TaskName { get; set; }
                public long? RobotId { get; set; }
                public string RobotName { get; set; }
                public long? Id { get; set; }
                public int? CompleteCount { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
