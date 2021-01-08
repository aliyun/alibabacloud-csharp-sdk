// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class ListStorageVideoTasksResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListStorageVideoTasksResponseData Data { get; set; }
        public class ListStorageVideoTasksResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("Count")]
            [Validation(Required=true)]
            public long? Count { get; set; }
            [NameInMap("TaskList")]
            [Validation(Required=true)]
            public List<ListStorageVideoTasksResponseDataTaskList> TaskList { get; set; }
            public class ListStorageVideoTasksResponseDataTaskList : TeaModel {
                public long? TaskId { get; set; }
                public string VideoId { get; set; }
                public string VideoName { get; set; }
                public long? ProcessTime { get; set; }
                public int? StorageInfo { get; set; }
                public long? ModifiedTime { get; set; }
                public string Status { get; set; }
                public string ErrorDetail { get; set; }
                public string RemoteTaskId { get; set; }
                public string Description { get; set; }
                public string VideoUrl { get; set; }
            }
        };

    }

}
