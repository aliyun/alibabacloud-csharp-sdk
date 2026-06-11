// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetRunConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The run configuration.</para>
        /// </summary>
        [NameInMap("runConfiguration")]
        [Validation(Required=false)]
        public GetRunConfigurationResponseBodyRunConfiguration RunConfiguration { get; set; }
        public class GetRunConfigurationResponseBodyRunConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of Spark configuration parameters.</para>
            /// </summary>
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<GetRunConfigurationResponseBodyRunConfigurationApplicationConfigs> ApplicationConfigs { get; set; }
            public class GetRunConfigurationResponseBodyRunConfigurationApplicationConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the application configuration file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark-defaults.conf</para>
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// <para>The key of the configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark.driver.cores</para>
                /// </summary>
                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                /// <summary>
                /// <para>The value of the configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

            /// <summary>
            /// <para>The log configuration.</para>
            /// </summary>
            [NameInMap("logConfig")]
            [Validation(Required=false)]
            public GetRunConfigurationResponseBodyRunConfigurationLogConfig LogConfig { get; set; }
            public class GetRunConfigurationResponseBodyRunConfigurationLogConfig : TeaModel {
                /// <summary>
                /// <para>The log level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

                /// <summary>
                /// <para>The log path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test</para>
                /// </summary>
                [NameInMap("LogPath")]
                [Validation(Required=false)]
                public string LogPath { get; set; }

            }

            /// <summary>
            /// <para>The list of runtime parameters.</para>
            /// </summary>
            [NameInMap("runtimeConfigs")]
            [Validation(Required=false)]
            public List<Tag> RuntimeConfigs { get; set; }

        }

    }

}
