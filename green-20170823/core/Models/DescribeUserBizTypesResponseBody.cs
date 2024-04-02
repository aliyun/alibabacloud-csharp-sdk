// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeUserBizTypesResponseBody : TeaModel {
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<DescribeUserBizTypesResponseBodyBizTypeList> BizTypeList { get; set; }
        public class DescribeUserBizTypesResponseBodyBizTypeList : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("CiteTemplate")]
            [Validation(Required=false)]
            public bool? CiteTemplate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Gray")]
            [Validation(Required=false)]
            public bool? Gray { get; set; }

            [NameInMap("IndustryInfo")]
            [Validation(Required=false)]
            public string IndustryInfo { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceBizType")]
            [Validation(Required=false)]
            public string SourceBizType { get; set; }

        }

        [NameInMap("BizTypeListImport")]
        [Validation(Required=false)]
        public List<DescribeUserBizTypesResponseBodyBizTypeListImport> BizTypeListImport { get; set; }
        public class DescribeUserBizTypesResponseBodyBizTypeListImport : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("CiteTemplate")]
            [Validation(Required=false)]
            public bool? CiteTemplate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Gray")]
            [Validation(Required=false)]
            public bool? Gray { get; set; }

            [NameInMap("IndustryInfo")]
            [Validation(Required=false)]
            public string IndustryInfo { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceBizType")]
            [Validation(Required=false)]
            public string SourceBizType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
