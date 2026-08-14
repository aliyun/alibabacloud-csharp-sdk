// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAreaBlockConfigsResponseBody : TeaModel {
        [NameInMap("AreaBlockConfigs")]
        [Validation(Required=false)]
        public List<DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigs> AreaBlockConfigs { get; set; }
        public class DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigs : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigsRegionList> RegionList { get; set; }
            public class DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigsRegionList : TeaModel {
                [NameInMap("Block")]
                [Validation(Required=false)]
                public int? Block { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
