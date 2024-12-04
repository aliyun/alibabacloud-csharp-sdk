// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("internetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            [NameInMap("intranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
