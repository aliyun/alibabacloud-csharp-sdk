// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiVersionListResponseBody : TeaModel {
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("VersionList")]
        [Validation(Required=false)]
        public List<DescribePopApiVersionListResponseBodyVersionList> VersionList { get; set; }
        public class DescribePopApiVersionListResponseBodyVersionList : TeaModel {
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("PopCode")]
            [Validation(Required=false)]
            public string PopCode { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
