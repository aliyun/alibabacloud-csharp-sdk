// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Image_detect20211221.Models
{
    public class GetTaskListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public GetTaskListResponseBodyResponse Response { get; set; }
        public class GetTaskListResponseBodyResponse : TeaModel {
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<GetTaskListResponseBodyResponseTaskList> TaskList { get; set; }
            public class GetTaskListResponseBodyResponseTaskList : TeaModel {
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public int? Level { get; set; }
                public string Priority { get; set; }
                public string TaskDescription { get; set; }
                public string TaskName { get; set; }
                public string TaskStatus { get; set; }
                public string TaskUid { get; set; }
            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
