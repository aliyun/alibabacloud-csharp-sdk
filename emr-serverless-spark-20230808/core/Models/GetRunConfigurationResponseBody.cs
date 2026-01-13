// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetRunConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("runConfiguration")]
        [Validation(Required=false)]
        public GetRunConfigurationResponseBodyRunConfiguration RunConfiguration { get; set; }
        public class GetRunConfigurationResponseBodyRunConfiguration : TeaModel {
            /// <summary>
            /// <para>应用配置项</para>
            /// </summary>
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<GetRunConfigurationResponseBodyRunConfigurationApplicationConfigs> ApplicationConfigs { get; set; }
            public class GetRunConfigurationResponseBodyRunConfigurationApplicationConfigs : TeaModel {
                /// <summary>
                /// <para>应用配置文件名。 应用配置文件名。 <c>spark-defaults.conf</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>spark-defaults.conf</para>
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// <para>配置项键。 配置项键。 <c>dfs.namenode.checkpoint.period</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>spark.driver.cores</para>
                /// </summary>
                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                /// <summary>
                /// <para>配置项值。 配置项值。 <c>3600s</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

            [NameInMap("logConfig")]
            [Validation(Required=false)]
            public GetRunConfigurationResponseBodyRunConfigurationLogConfig LogConfig { get; set; }
            public class GetRunConfigurationResponseBodyRunConfigurationLogConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://test</para>
                /// </summary>
                [NameInMap("LogPath")]
                [Validation(Required=false)]
                public string LogPath { get; set; }

            }

            /// <summary>
            /// <para>运行配置。</para>
            /// </summary>
            [NameInMap("runtimeConfigs")]
            [Validation(Required=false)]
            public List<Tag> RuntimeConfigs { get; set; }

        }

    }

}
