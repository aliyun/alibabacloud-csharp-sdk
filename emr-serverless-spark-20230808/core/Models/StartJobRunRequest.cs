// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class StartJobRunRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("codeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        [NameInMap("configurationOverrides")]
        [Validation(Required=false)]
        public StartJobRunRequestConfigurationOverrides ConfigurationOverrides { get; set; }
        public class StartJobRunRequestConfigurationOverrides : TeaModel {
            [NameInMap("configurations")]
            [Validation(Required=false)]
            public List<StartJobRunRequestConfigurationOverridesConfigurations> Configurations { get; set; }
            public class StartJobRunRequestConfigurationOverridesConfigurations : TeaModel {
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

        }

        [NameInMap("executionTimeoutSeconds")]
        [Validation(Required=false)]
        public int? ExecutionTimeoutSeconds { get; set; }

        [NameInMap("jobDriver")]
        [Validation(Required=false)]
        public JobDriver JobDriver { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
