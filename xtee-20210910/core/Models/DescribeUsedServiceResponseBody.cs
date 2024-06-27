// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeUsedServiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<DescribeUsedServiceResponseBodyRecords> Records { get; set; }
        public class DescribeUsedServiceResponseBodyRecords : TeaModel {
            [NameInMap("enName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("serviceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

        }

    }

}
