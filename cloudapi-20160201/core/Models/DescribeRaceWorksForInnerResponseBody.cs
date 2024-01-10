// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribeRaceWorksForInnerResponseBody : TeaModel {
        [NameInMap("ApiWorks")]
        [Validation(Required=false)]
        public DescribeRaceWorksForInnerResponseBodyApiWorks ApiWorks { get; set; }
        public class DescribeRaceWorksForInnerResponseBodyApiWorks : TeaModel {
            [NameInMap("ApiWork")]
            [Validation(Required=false)]
            public List<DescribeRaceWorksForInnerResponseBodyApiWorksApiWork> ApiWork { get; set; }
            public class DescribeRaceWorksForInnerResponseBodyApiWorksApiWork : TeaModel {
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public string Keywords { get; set; }

                [NameInMap("LogoUrl")]
                [Validation(Required=false)]
                public string LogoUrl { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

                [NameInMap("WorkName")]
                [Validation(Required=false)]
                public string WorkName { get; set; }

            }

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
