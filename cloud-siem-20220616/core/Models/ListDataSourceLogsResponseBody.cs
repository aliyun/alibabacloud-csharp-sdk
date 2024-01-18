// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDataSourceLogsResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSourceLogsResponseBodyData Data { get; set; }
        public class ListDataSourceLogsResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The code that is used for multi-cloud environments. Valid values:
            /// 
            /// *   qcloud: Tencent Cloud
            /// *   aliyun: Alibaba Cloud
            /// *   hcloud: Huawei Cloud
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// The ID of the data source. The value is obtained after the threat analysis feature calculates the MD5 hash value of a parameter.
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            /// <summary>
            /// The logs of the data source.
            /// </summary>
            [NameInMap("DataSourceInstanceLogs")]
            [Validation(Required=false)]
            public List<ListDataSourceLogsResponseBodyDataDataSourceInstanceLogs> DataSourceInstanceLogs { get; set; }
            public class ListDataSourceLogsResponseBodyDataDataSourceInstanceLogs : TeaModel {
                /// <summary>
                /// The code of the log.
                /// </summary>
                [NameInMap("LogCode")]
                [Validation(Required=false)]
                public string LogCode { get; set; }

                /// <summary>
                /// The ID of the log. The value is obtained after the threat analysis feature calculates the MD5 hash value of a parameter.
                /// </summary>
                [NameInMap("LogInstanceId")]
                [Validation(Required=false)]
                public string LogInstanceId { get; set; }

                /// <summary>
                /// The display code of the log.
                /// </summary>
                [NameInMap("LogMdsCode")]
                [Validation(Required=false)]
                public string LogMdsCode { get; set; }

                /// <summary>
                /// The parameters of the log.
                /// </summary>
                [NameInMap("LogParams")]
                [Validation(Required=false)]
                public List<ListDataSourceLogsResponseBodyDataDataSourceInstanceLogsLogParams> LogParams { get; set; }
                public class ListDataSourceLogsResponseBodyDataDataSourceInstanceLogsLogParams : TeaModel {
                    /// <summary>
                    /// The parameter code of the log.
                    /// </summary>
                    [NameInMap("ParaCode")]
                    [Validation(Required=false)]
                    public string ParaCode { get; set; }

                    /// <summary>
                    /// The parameter value of the log.
                    /// </summary>
                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }

                }

                /// <summary>
                /// Indicates whether the task for which logs are collected is enabled. Valid values:
                /// 
                /// *   1: yes
                /// *   0: no
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

            }

            /// <summary>
            /// The name of the data source.
            /// </summary>
            [NameInMap("DataSourceInstanceName")]
            [Validation(Required=false)]
            public string DataSourceInstanceName { get; set; }

            /// <summary>
            /// The remarks of the data source.
            /// </summary>
            [NameInMap("DataSourceInstanceRemark")]
            [Validation(Required=false)]
            public string DataSourceInstanceRemark { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
