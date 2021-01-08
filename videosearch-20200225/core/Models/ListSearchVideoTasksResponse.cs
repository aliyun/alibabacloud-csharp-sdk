// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class ListSearchVideoTasksResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListSearchVideoTasksResponseData Data { get; set; }
        public class ListSearchVideoTasksResponseData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=true)]
            public long? Count { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TaskList")]
            [Validation(Required=true)]
            public List<ListSearchVideoTasksResponseDataTaskList> TaskList { get; set; }
            public class ListSearchVideoTasksResponseDataTaskList : TeaModel {
                public string TaskId { get; set; }
                public string VideoId { get; set; }
                public string VideoName { get; set; }
                public long? ProcessTime { get; set; }
                public int? Status { get; set; }
                public long? ModifiedTime { get; set; }
                public string ProcessResultUrl { get; set; }
                public int? StorageType { get; set; }
                public int? StorageInfo { get; set; }
                public string VideoUrl { get; set; }
                public string ErrorDetail { get; set; }
                public string ReplaceStorageThreshold { get; set; }
                public string QueryTags { get; set; }
                public string RemoteTaskId { get; set; }
                public string VideoTags { get; set; }
                public int? SearchType { get; set; }
                public string Description { get; set; }
            }
        };

    }

}
