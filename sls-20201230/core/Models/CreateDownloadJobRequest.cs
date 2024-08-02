// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateDownloadJobRequest : TeaModel {
        /// <summary>
        /// 下载配置
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public CreateDownloadJobRequestConfiguration Configuration { get; set; }
        public class CreateDownloadJobRequestConfiguration : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("allowInComplete")]
            [Validation(Required=false)]
            public bool? AllowInComplete { get; set; }

            /// <summary>
            /// 起点时间戳（精确到秒）
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// 源logstore
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// 是否启用powerSql
            /// </summary>
            [NameInMap("powerSql")]
            [Validation(Required=false)]
            public bool? PowerSql { get; set; }

            /// <summary>
            /// 查询语句
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// 导出配置
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public CreateDownloadJobRequestConfigurationSink Sink { get; set; }
            public class CreateDownloadJobRequestConfigurationSink : TeaModel {
                /// <summary>
                /// 对象存储桶
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// 压缩格式
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("compressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// 下载文件格式
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// 下载使用roleArn
                /// </summary>
                [NameInMap("roleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 结束时间戳（精确到秒）
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

        }

        /// <summary>
        /// 任务描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 任务显示名称
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 代表资源名称的资源属性字段
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
