// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListProjectsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProjectsResponseBodyData> Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            [NameInMap("AccessPageId")]
            [Validation(Required=false)]
            public List<long?> AccessPageId { get; set; }

            [NameInMap("AvailableHours")]
            [Validation(Required=false)]
            public int? AvailableHours { get; set; }

            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }

            [NameInMap("ContentName")]
            [Validation(Required=false)]
            public string ContentName { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InUseSessions")]
            [Validation(Required=false)]
            public long? InUseSessions { get; set; }

            [NameInMap("MaxHours")]
            [Validation(Required=false)]
            public long? MaxHours { get; set; }

            [NameInMap("MaxSessions")]
            [Validation(Required=false)]
            public long? MaxSessions { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("ProjectState")]
            [Validation(Required=false)]
            public string ProjectState { get; set; }

            [NameInMap("SessionSpec")]
            [Validation(Required=false)]
            public string SessionSpec { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
