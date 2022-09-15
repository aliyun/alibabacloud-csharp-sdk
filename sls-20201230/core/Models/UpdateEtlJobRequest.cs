// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateEtlJobRequest : TeaModel {
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("etlJobName")]
        [Validation(Required=false)]
        public string EtlJobName { get; set; }

        [NameInMap("functionConfig")]
        [Validation(Required=false)]
        public UpdateEtlJobRequestFunctionConfig FunctionConfig { get; set; }
        public class UpdateEtlJobRequestFunctionConfig : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("functionProvider")]
            [Validation(Required=false)]
            public string FunctionProvider { get; set; }

            [NameInMap("regionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("functionParameter")]
        [Validation(Required=false)]
        public Dictionary<string, object> FunctionParameter { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public UpdateEtlJobRequestLogConfig LogConfig { get; set; }
        public class UpdateEtlJobRequestLogConfig : TeaModel {
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

        [NameInMap("sourceConfig")]
        [Validation(Required=false)]
        public UpdateEtlJobRequestSourceConfig SourceConfig { get; set; }
        public class UpdateEtlJobRequestSourceConfig : TeaModel {
            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

        }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public UpdateEtlJobRequestTriggerConfig TriggerConfig { get; set; }
        public class UpdateEtlJobRequestTriggerConfig : TeaModel {
            [NameInMap("maxRetryTime")]
            [Validation(Required=false)]
            public int? MaxRetryTime { get; set; }

            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("startingPosition")]
            [Validation(Required=false)]
            public string StartingPosition { get; set; }

            [NameInMap("startingUnixtime")]
            [Validation(Required=false)]
            public long? StartingUnixtime { get; set; }

            [NameInMap("triggerInterval")]
            [Validation(Required=false)]
            public int? TriggerInterval { get; set; }

        }

    }

}
