// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeAreasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Areas")]
        [Validation(Required=false)]
        public DescribeAreasResponseBodyAreas Areas { get; set; }
        public class DescribeAreasResponseBodyAreas : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public List<DescribeAreasResponseBodyAreasArea> Area { get; set; }
            public class DescribeAreasResponseBodyAreasArea : TeaModel {
                public string LocalName { get; set; }
                public string AreaId { get; set; }
            }
        };

    }

}
