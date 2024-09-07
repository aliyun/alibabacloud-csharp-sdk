// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetCommonLogDetailResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("LogDetail")]
        [Validation(Required=false)]
        public List<GetCommonLogDetailResponseBodyLogDetail> LogDetail { get; set; }
        public class GetCommonLogDetailResponseBodyLogDetail : TeaModel {
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<GetCommonLogDetailResponseBodyLogDetailStages> Stages { get; set; }
            public class GetCommonLogDetailResponseBodyLogDetailStages : TeaModel {
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("OperatorUid")]
        [Validation(Required=false)]
        public string OperatorUid { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
