// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeOssResultItemsResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScanResultList")]
        [Validation(Required=false)]
        public List<DescribeOssResultItemsResponseBodyScanResultList> ScanResultList { get; set; }
        public class DescribeOssResultItemsResponseBodyScanResultList : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("FrameResults")]
            [Validation(Required=false)]
            public List<DescribeOssResultItemsResponseBodyScanResultListFrameResults> FrameResults { get; set; }
            public class DescribeOssResultItemsResponseBodyScanResultListFrameResults : TeaModel {
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("HandleStatus")]
            [Validation(Required=false)]
            public int? HandleStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("NewUrl")]
            [Validation(Required=false)]
            public string NewUrl { get; set; }

            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public int? ResourceStatus { get; set; }

            [NameInMap("ScanFinishedTime")]
            [Validation(Required=false)]
            public string ScanFinishedTime { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

            [NameInMap("VoiceSegmentAntispamResults")]
            [Validation(Required=false)]
            public List<DescribeOssResultItemsResponseBodyScanResultListVoiceSegmentAntispamResults> VoiceSegmentAntispamResults { get; set; }
            public class DescribeOssResultItemsResponseBodyScanResultListVoiceSegmentAntispamResults : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public int? EndTime { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public int? StartTime { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
