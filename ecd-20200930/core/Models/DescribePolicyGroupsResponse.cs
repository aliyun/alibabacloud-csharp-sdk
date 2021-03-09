// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePolicyGroupsResponse : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=true)]
        public List<DescribePolicyGroupsResponseDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseDescribePolicyGroups : TeaModel {
            [NameInMap("PolicyGroupId")]
            [Validation(Required=true)]
            public string PolicyGroupId { get; set; }

            [NameInMap("PolicyGroupType")]
            [Validation(Required=true)]
            public string PolicyGroupType { get; set; }

            [NameInMap("Clipboard")]
            [Validation(Required=true)]
            public string Clipboard { get; set; }

            [NameInMap("LocalDrive")]
            [Validation(Required=true)]
            public string LocalDrive { get; set; }

            [NameInMap("UsbRedirect")]
            [Validation(Required=true)]
            public string UsbRedirect { get; set; }

            [NameInMap("Watermark")]
            [Validation(Required=true)]
            public string Watermark { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("WatermarkType")]
            [Validation(Required=true)]
            public string WatermarkType { get; set; }

            [NameInMap("WatermarkCustomText")]
            [Validation(Required=true)]
            public string WatermarkCustomText { get; set; }

            [NameInMap("WatermarkTransparency")]
            [Validation(Required=true)]
            public string WatermarkTransparency { get; set; }

            [NameInMap("PolicyStatus")]
            [Validation(Required=true)]
            public string PolicyStatus { get; set; }

            [NameInMap("EdsCount")]
            [Validation(Required=true)]
            public int? EdsCount { get; set; }

        }

    }

}
