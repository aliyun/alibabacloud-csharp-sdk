// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskListResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetSyntheticTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class GetSyntheticTaskListResponseBodyPageInfo : TeaModel {
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public string HasNextPage { get; set; }

            [NameInMap("HasPreviousPage")]
            [Validation(Required=false)]
            public bool? HasPreviousPage { get; set; }

            [NameInMap("IsFirstPage")]
            [Validation(Required=false)]
            public bool? IsFirstPage { get; set; }

            [NameInMap("IsLastPage")]
            [Validation(Required=false)]
            public bool? IsLastPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetSyntheticTaskListResponseBodyPageInfoList> List { get; set; }
            public class GetSyntheticTaskListResponseBodyPageInfoList : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("MonitorNumber")]
                [Validation(Required=false)]
                public long? MonitorNumber { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public long? TaskType { get; set; }

                [NameInMap("TaskTypeName")]
                [Validation(Required=false)]
                public string TaskTypeName { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("Usable")]
                [Validation(Required=false)]
                public float? Usable { get; set; }

            }

            [NameInMap("NavigateFirstPage")]
            [Validation(Required=false)]
            public string NavigateFirstPage { get; set; }

            [NameInMap("NavigateLastPage")]
            [Validation(Required=false)]
            public string NavigateLastPage { get; set; }

            [NameInMap("NavigatePageNums")]
            [Validation(Required=false)]
            public string NavigatePageNums { get; set; }

            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public string NextPage { get; set; }

            [NameInMap("Pages")]
            [Validation(Required=false)]
            public string Pages { get; set; }

            [NameInMap("Prepage")]
            [Validation(Required=false)]
            public string Prepage { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
