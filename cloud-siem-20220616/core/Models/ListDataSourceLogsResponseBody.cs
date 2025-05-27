// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDataSourceLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSourceLogsResponseBodyData Data { get; set; }
        public class ListDataSourceLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The code that is used for multi-cloud environments. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>qcloud: Tencent Cloud</description></item>
            /// <item><description>aliyun: Alibaba Cloud</description></item>
            /// <item><description>hcloud: Huawei Cloud</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The ID of the data source. The value is obtained after the threat analysis feature calculates the MD5 hash value of a parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            /// <summary>
            /// <para>The logs of the data source.</para>
            /// </summary>
            [NameInMap("DataSourceInstanceLogs")]
            [Validation(Required=false)]
            public List<ListDataSourceLogsResponseBodyDataDataSourceInstanceLogs> DataSourceInstanceLogs { get; set; }
            public class ListDataSourceLogsResponseBodyDataDataSourceInstanceLogs : TeaModel {
                /// <summary>
                /// <para>The code of the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_siem_waf_xxxxx</para>
                /// </summary>
                [NameInMap("LogCode")]
                [Validation(Required=false)]
                public string LogCode { get; set; }

                /// <summary>
                /// <para>The ID of the log. The value is obtained after the threat analysis feature calculates the MD5 hash value of a parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
                /// </summary>
                [NameInMap("LogInstanceId")]
                [Validation(Required=false)]
                public string LogInstanceId { get; set; }

                /// <summary>
                /// <para>The display code of the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${siem.prod.cloud_siem_waf_xxxxx}</para>
                /// </summary>
                [NameInMap("LogMdsCode")]
                [Validation(Required=false)]
                public string LogMdsCode { get; set; }

                /// <summary>
                /// <para>The parameters of the log.</para>
                /// </summary>
                [NameInMap("LogParams")]
                [Validation(Required=false)]
                public List<ListDataSourceLogsResponseBodyDataDataSourceInstanceLogsLogParams> LogParams { get; set; }
                public class ListDataSourceLogsResponseBodyDataDataSourceInstanceLogsLogParams : TeaModel {
                    /// <summary>
                    /// <para>The parameter code of the log.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region_code</para>
                    /// </summary>
                    [NameInMap("ParaCode")]
                    [Validation(Required=false)]
                    public string ParaCode { get; set; }

                    /// <summary>
                    /// <para>The parameter value of the log.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ap-guangzhou</para>
                    /// </summary>
                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the task for which logs are collected is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: yes</description></item>
                /// <item><description>0: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

            }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf kafka</para>
            /// </summary>
            [NameInMap("DataSourceInstanceName")]
            [Validation(Required=false)]
            public string DataSourceInstanceName { get; set; }

            /// <summary>
            /// <para>The remarks of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf kafka</para>
            /// </summary>
            [NameInMap("DataSourceInstanceRemark")]
            [Validation(Required=false)]
            public string DataSourceInstanceRemark { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
