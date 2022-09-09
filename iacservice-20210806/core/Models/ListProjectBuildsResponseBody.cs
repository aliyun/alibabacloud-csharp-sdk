// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListProjectBuildsResponseBody : TeaModel {
        [NameInMap("ProjectBuilds")]
        [Validation(Required=false)]
        public List<ListProjectBuildsResponseBodyProjectBuilds> ProjectBuilds { get; set; }
        public class ListProjectBuildsResponseBodyProjectBuilds : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("projectBuildAction")]
            [Validation(Required=false)]
            public string ProjectBuildAction { get; set; }

            [NameInMap("projectBuildId")]
            [Validation(Required=false)]
            public string ProjectBuildId { get; set; }

            [NameInMap("projectBuildIndex")]
            [Validation(Required=false)]
            public long? ProjectBuildIndex { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
