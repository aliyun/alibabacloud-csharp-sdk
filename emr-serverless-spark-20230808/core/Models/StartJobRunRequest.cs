// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class StartJobRunRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The code type of the job. Valid values:
        /// 
        /// *   SQL
        /// *   JAR
        /// *   PYTHON
        /// </summary>
        [NameInMap("codeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// The advanced configurations of Spark.
        /// </summary>
        [NameInMap("configurationOverrides")]
        [Validation(Required=false)]
        public StartJobRunRequestConfigurationOverrides ConfigurationOverrides { get; set; }
        public class StartJobRunRequestConfigurationOverrides : TeaModel {
            /// <summary>
            /// The SparkConf objects.
            /// </summary>
            [NameInMap("configurations")]
            [Validation(Required=false)]
            public List<StartJobRunRequestConfigurationOverridesConfigurations> Configurations { get; set; }
            public class StartJobRunRequestConfigurationOverridesConfigurations : TeaModel {
                /// <summary>
                /// The configuration file of SparkConf.
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// The key of SparkConf.
                /// </summary>
                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                /// <summary>
                /// The value of SparkConf.
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

        }

        /// <summary>
        /// The timeout period of the job.
        /// </summary>
        [NameInMap("executionTimeoutSeconds")]
        [Validation(Required=false)]
        public int? ExecutionTimeoutSeconds { get; set; }

        /// <summary>
        /// The information about Spark Driver.
        /// </summary>
        [NameInMap("jobDriver")]
        [Validation(Required=false)]
        public JobDriver JobDriver { get; set; }

        /// <summary>
        /// The job ID.
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The job name.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The version number of Spark.
        /// </summary>
        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// The name of the resource queue on which the Spark job runs.
        /// </summary>
        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        /// <summary>
        /// The tags of the job.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
