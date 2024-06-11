// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeSpecResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpecInfoModel")]
        [Validation(Required=false)]
        public List<DescribeSpecResponseBodySpecInfoModel> SpecInfoModel { get; set; }
        public class DescribeSpecResponseBodySpecInfoModel : TeaModel {
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

            [NameInMap("SpecStatus")]
            [Validation(Required=false)]
            public string SpecStatus { get; set; }

            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
