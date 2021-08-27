// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeManagedInstancesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeManagedInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeManagedInstancesResponseBodyInstances : TeaModel {
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            [NameInMap("Connected")]
            [Validation(Required=false)]
            public bool? Connected { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            [NameInMap("RegistrationTime")]
            [Validation(Required=false)]
            public string RegistrationTime { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            [NameInMap("MachineId")]
            [Validation(Required=false)]
            public string MachineId { get; set; }

        }

    }

}
