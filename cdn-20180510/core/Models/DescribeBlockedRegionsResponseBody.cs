// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeBlockedRegionsResponseBody : TeaModel {
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public DescribeBlockedRegionsResponseBodyInfoList InfoList { get; set; }
        public class DescribeBlockedRegionsResponseBodyInfoList : TeaModel {
            [NameInMap("InfoItem")]
            [Validation(Required=false)]
            public List<DescribeBlockedRegionsResponseBodyInfoListInfoItem> InfoItem { get; set; }
            public class DescribeBlockedRegionsResponseBodyInfoListInfoItem : TeaModel {
                public string Continent { get; set; }
                public string CountriesAndRegions { get; set; }
                public string CountriesAndRegionsName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
