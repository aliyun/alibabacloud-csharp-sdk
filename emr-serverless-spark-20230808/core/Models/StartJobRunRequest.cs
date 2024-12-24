// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class StartJobRunRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8e6aae2810c8f67229ca70bb31cd6028</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The code type of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL</description></item>
        /// <item><description>JAR</description></item>
        /// <item><description>PYTHON</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("codeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// <para>The advanced configurations of Spark.</para>
        /// </summary>
        [NameInMap("configurationOverrides")]
        [Validation(Required=false)]
        public StartJobRunRequestConfigurationOverrides ConfigurationOverrides { get; set; }
        public class StartJobRunRequestConfigurationOverrides : TeaModel {
            /// <summary>
            /// <para>The SparkConf objects.</para>
            /// </summary>
            [NameInMap("configurations")]
            [Validation(Required=false)]
            public List<StartJobRunRequestConfigurationOverridesConfigurations> Configurations { get; set; }
            public class StartJobRunRequestConfigurationOverridesConfigurations : TeaModel {
                /// <summary>
                /// <para>The configuration file of SparkConf.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark-default.conf</para>
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// <para>The key of SparkConf.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark.app.name</para>
                /// </summary>
                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                /// <summary>
                /// <para>The value of SparkConf.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_app</para>
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

        }

        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>The timeout period of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("executionTimeoutSeconds")]
        [Validation(Required=false)]
        public int? ExecutionTimeoutSeconds { get; set; }

        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>The information about Spark Driver.</para>
        /// </summary>
        [NameInMap("jobDriver")]
        [Validation(Required=false)]
        public JobDriver JobDriver { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jr-12345</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark_job_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version number of Spark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-3.3.1</para>
        /// </summary>
        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The name of the resource queue on which the Spark job runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_queue</para>
        /// </summary>
        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
