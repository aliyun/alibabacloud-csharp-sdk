// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSuspEventQuaraFilesResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("QuaraFiles")]
        [Validation(Required=false)]
        public List<DescribeSuspEventQuaraFilesResponseBodyQuaraFiles> QuaraFiles { get; set; }
        public class DescribeSuspEventQuaraFilesResponseBodyQuaraFiles : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

    }

}
