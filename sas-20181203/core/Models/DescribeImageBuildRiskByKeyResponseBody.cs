// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskByKeyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageBuildRiskByKeyResponseBodyData Data { get; set; }
        public class DescribeImageBuildRiskByKeyResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageBuildRiskByKeyResponseBodyDataList> List { get; set; }
            public class DescribeImageBuildRiskByKeyResponseBodyDataList : TeaModel {
                [NameInMap("Advice")]
                [Validation(Required=false)]
                public string Advice { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("LayerCmd")]
                [Validation(Required=false)]
                public string LayerCmd { get; set; }

                [NameInMap("LayerDigest")]
                [Validation(Required=false)]
                public string LayerDigest { get; set; }

                [NameInMap("Promt")]
                [Validation(Required=false)]
                public string Promt { get; set; }

                [NameInMap("RiskClass")]
                [Validation(Required=false)]
                public string RiskClass { get; set; }

                [NameInMap("RiskClassName")]
                [Validation(Required=false)]
                public string RiskClassName { get; set; }

                [NameInMap("RiskKey")]
                [Validation(Required=false)]
                public string RiskKey { get; set; }

                [NameInMap("RiskKeyName")]
                [Validation(Required=false)]
                public string RiskKeyName { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageBuildRiskByKeyResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageBuildRiskByKeyResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
