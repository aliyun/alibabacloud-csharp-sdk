// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class ListAppSessionsResponseBody : TeaModel {
        [NameInMap("AppSessions")]
        [Validation(Required=false)]
        public List<ListAppSessionsResponseBodyAppSessions> AppSessions { get; set; }
        public class ListAppSessionsResponseBodyAppSessions : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// 业务特定的信息，如会话启动/停止时间。
            /// </summary>
            [NameInMap("BizInfo")]
            [Validation(Required=false)]
            public ListAppSessionsResponseBodyAppSessionsBizInfo BizInfo { get; set; }
            public class ListAppSessionsResponseBodyAppSessionsBizInfo : TeaModel {
                /// <summary>
                /// 会话启动时间
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// 会话停止时间
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

            }

            [NameInMap("CustomSessionId")]
            [Validation(Required=false)]
            public string CustomSessionId { get; set; }

            [NameInMap("PlatformSessionId")]
            [Validation(Required=false)]
            public string PlatformSessionId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
