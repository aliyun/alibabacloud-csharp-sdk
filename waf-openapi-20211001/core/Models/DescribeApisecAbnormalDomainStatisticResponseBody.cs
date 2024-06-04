// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAbnormalDomainStatisticResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecAbnormalDomainStatisticResponseBodyData> Data { get; set; }
        public class DescribeApisecAbnormalDomainStatisticResponseBodyData : TeaModel {
            [NameInMap("ApiCount")]
            [Validation(Required=false)]
            public long? ApiCount { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("High")]
            [Validation(Required=false)]
            public long? High { get; set; }

            [NameInMap("Low")]
            [Validation(Required=false)]
            public long? Low { get; set; }

            [NameInMap("Medium")]
            [Validation(Required=false)]
            public long? Medium { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
