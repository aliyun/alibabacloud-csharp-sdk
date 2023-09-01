// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceHAResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceHAResponseBodyData Data { get; set; }
        public class DescribeDBInstanceHAResponseBodyData : TeaModel {
            [NameInMap("PrimaryAzoneId")]
            [Validation(Required=false)]
            public string PrimaryAzoneId { get; set; }

            [NameInMap("PrimaryRegionId")]
            [Validation(Required=false)]
            public string PrimaryRegionId { get; set; }

            [NameInMap("SecondaryAzoneId")]
            [Validation(Required=false)]
            public string SecondaryAzoneId { get; set; }

            [NameInMap("SecondaryRegionId")]
            [Validation(Required=false)]
            public string SecondaryRegionId { get; set; }

            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
