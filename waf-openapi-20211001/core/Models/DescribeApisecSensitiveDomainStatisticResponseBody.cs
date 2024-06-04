// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecSensitiveDomainStatisticResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecSensitiveDomainStatisticResponseBodyData> Data { get; set; }
        public class DescribeApisecSensitiveDomainStatisticResponseBodyData : TeaModel {
            [NameInMap("ApiCount")]
            [Validation(Required=false)]
            public long? ApiCount { get; set; }

            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            [NameInMap("SensitiveCode")]
            [Validation(Required=false)]
            public string SensitiveCode { get; set; }

            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            [NameInMap("SensitiveName")]
            [Validation(Required=false)]
            public string SensitiveName { get; set; }

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
