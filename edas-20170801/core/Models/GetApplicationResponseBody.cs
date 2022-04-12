// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetApplicationResponseBody : TeaModel {
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public string ApplicationType { get; set; }
            [NameInMap("BuildPackageId")]
            [Validation(Required=false)]
            public long? BuildPackageId { get; set; }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Dockerize")]
            [Validation(Required=false)]
            public bool? Dockerize { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("ExtSlbId")]
            [Validation(Required=false)]
            public string ExtSlbId { get; set; }
            [NameInMap("ExtSlbIp")]
            [Validation(Required=false)]
            public string ExtSlbIp { get; set; }
            [NameInMap("ExtSlbName")]
            [Validation(Required=false)]
            public string ExtSlbName { get; set; }
            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NameSpace")]
            [Validation(Required=false)]
            public string NameSpace { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RunningInstanceCount")]
            [Validation(Required=false)]
            public int? RunningInstanceCount { get; set; }
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }
            [NameInMap("SlbInfo")]
            [Validation(Required=false)]
            public string SlbInfo { get; set; }
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }
            [NameInMap("SlbName")]
            [Validation(Required=false)]
            public string SlbName { get; set; }
            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public int? SlbPort { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
