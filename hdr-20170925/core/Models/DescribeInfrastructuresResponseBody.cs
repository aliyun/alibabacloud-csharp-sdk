// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeInfrastructuresResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Infrastructures")]
        [Validation(Required=false)]
        public DescribeInfrastructuresResponseBodyInfrastructures Infrastructures { get; set; }
        public class DescribeInfrastructuresResponseBodyInfrastructures : TeaModel {
            [NameInMap("infrastructure")]
            [Validation(Required=false)]
            public List<DescribeInfrastructuresResponseBodyInfrastructuresInfrastructure> Infrastructure { get; set; }
            public class DescribeInfrastructuresResponseBodyInfrastructuresInfrastructure : TeaModel {
                [NameInMap("Errno")]
                [Validation(Required=false)]
                public string Errno { get; set; }

                [NameInMap("InfrastructureId")]
                [Validation(Required=false)]
                public string InfrastructureId { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
