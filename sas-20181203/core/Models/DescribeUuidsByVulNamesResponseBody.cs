// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUuidsByVulNamesResponseBody : TeaModel {
        [NameInMap("MachineInfoStatistics")]
        [Validation(Required=false)]
        public List<DescribeUuidsByVulNamesResponseBodyMachineInfoStatistics> MachineInfoStatistics { get; set; }
        public class DescribeUuidsByVulNamesResponseBodyMachineInfoStatistics : TeaModel {
            [NameInMap("MachineInstanceId")]
            [Validation(Required=false)]
            public string MachineInstanceId { get; set; }

            [NameInMap("MachineIp")]
            [Validation(Required=false)]
            public string MachineIp { get; set; }

            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
