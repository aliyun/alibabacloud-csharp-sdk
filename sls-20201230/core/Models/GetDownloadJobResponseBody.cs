// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetDownloadJobResponseBody : TeaModel {
        /// <summary>
        /// 下载配置
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public GetDownloadJobResponseBodyConfiguration Configuration { get; set; }
        public class GetDownloadJobResponseBodyConfiguration : TeaModel {
            [NameInMap("allowInComplete")]
            [Validation(Required=false)]
            public bool? AllowInComplete { get; set; }

            /// <summary>
            /// 起点时间戳（精确到秒）
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// 源logstore
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
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// 导出配置
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public GetDownloadJobResponseBodyConfigurationSink Sink { get; set; }
            public class GetDownloadJobResponseBodyConfigurationSink : TeaModel {
                /// <summary>
                /// 对象存储桶
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// 压缩格式
                /// </summary>
                [NameInMap("compressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// 下载文件格式
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

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 结束时间戳（精确到秒）
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

        }

        /// <summary>
        /// 代表创建时间的资源属性字段
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 任务显示名称
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 任务执行细节
        /// </summary>
        [NameInMap("executionDetails")]
        [Validation(Required=false)]
        public GetDownloadJobResponseBodyExecutionDetails ExecutionDetails { get; set; }
        public class GetDownloadJobResponseBodyExecutionDetails : TeaModel {
            [NameInMap("checkSum")]
            [Validation(Required=false)]
            public string CheckSum { get; set; }

            /// <summary>
            /// 下载错误信息
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// 下载执行时间
            /// </summary>
            [NameInMap("executeTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            /// <summary>
            /// 下载结果链接
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// 下载文件大小
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// 下载日志条数
            /// </summary>
            [NameInMap("logCount")]
            [Validation(Required=false)]
            public long? LogCount { get; set; }

            /// <summary>
            /// 下载进度
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

        }

        /// <summary>
        /// 代表资源名称的资源属性字段
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 代表资源状态的资源属性字段
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
