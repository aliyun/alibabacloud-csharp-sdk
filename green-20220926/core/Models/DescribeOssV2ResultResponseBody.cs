// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DescribeOssV2ResultResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeOssV2ResultResponseBodyItems> Items { get; set; }
        public class DescribeOssV2ResultResponseBodyItems : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("Freeze")]
            [Validation(Required=false)]
            public bool? Freeze { get; set; }

            [NameInMap("FreezeStatus")]
            [Validation(Required=false)]
            public string FreezeStatus { get; set; }

            [NameInMap("FreezeType")]
            [Validation(Required=false)]
            public string FreezeType { get; set; }

            [NameInMap("LabelDetails")]
            [Validation(Required=false)]
            public List<DescribeOssV2ResultResponseBodyItemsLabelDetails> LabelDetails { get; set; }
            public class DescribeOssV2ResultResponseBodyItemsLabelDetails : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("LabelDetails2")]
            [Validation(Required=false)]
            public List<DescribeOssV2ResultResponseBodyItemsLabelDetails2> LabelDetails2 { get; set; }
            public class DescribeOssV2ResultResponseBodyItemsLabelDetails2 : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            [NameInMap("Labels2")]
            [Validation(Required=false)]
            public List<string> Labels2 { get; set; }

            [NameInMap("ManualFreezeAction")]
            [Validation(Required=false)]
            public string ManualFreezeAction { get; set; }

            [NameInMap("ManualOperateTime")]
            [Validation(Required=false)]
            public string ManualOperateTime { get; set; }

            [NameInMap("ManualOperator")]
            [Validation(Required=false)]
            public string ManualOperator { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("RiskLevel0")]
            [Validation(Required=false)]
            public string RiskLevel0 { get; set; }

            [NameInMap("RiskLevel2")]
            [Validation(Required=false)]
            public string RiskLevel2 { get; set; }

            [NameInMap("ScanResult")]
            [Validation(Required=false)]
            public string ScanResult { get; set; }

            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("SysDisposalStatus")]
            [Validation(Required=false)]
            public string SysDisposalStatus { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
