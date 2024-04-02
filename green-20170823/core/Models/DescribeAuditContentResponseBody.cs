// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeAuditContentResponseBody : TeaModel {
        [NameInMap("AuditContentList")]
        [Validation(Required=false)]
        public List<DescribeAuditContentResponseBodyAuditContentList> AuditContentList { get; set; }
        public class DescribeAuditContentResponseBodyAuditContentList : TeaModel {
            [NameInMap("Audit")]
            [Validation(Required=false)]
            public int? Audit { get; set; }

            [NameInMap("AuditIllegalReasons")]
            [Validation(Required=false)]
            public List<string> AuditIllegalReasons { get; set; }

            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("FrameResults")]
            [Validation(Required=false)]
            public List<DescribeAuditContentResponseBodyAuditContentListFrameResults> FrameResults { get; set; }
            public class DescribeAuditContentResponseBodyAuditContentListFrameResults : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("NewUrl")]
            [Validation(Required=false)]
            public string NewUrl { get; set; }

            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<DescribeAuditContentResponseBodyAuditContentListResults> Results { get; set; }
            public class DescribeAuditContentResponseBodyAuditContentListResults : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            [NameInMap("ScanFinishedTime")]
            [Validation(Required=false)]
            public string ScanFinishedTime { get; set; }

            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
