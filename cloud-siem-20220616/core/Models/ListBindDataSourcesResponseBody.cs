// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListBindDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBindDataSourcesResponseBodyData> Data { get; set; }
        public class ListBindDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The name of the multicloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_tq_account_xxxx</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The code of the multicloud environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>qcloud: Tencent Cloud.</para>
            /// </description></item>
            /// <item><description><para>aliyun: Alibaba Cloud.</para>
            /// </description></item>
            /// <item><description><para>hcloud: Huawei Cloud.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The ID of the data source. This ID is an MD5 hash value that is calculated by Threat Analysis based on specific parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_kafka</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The remarks of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_kafka</para>
            /// </summary>
            [NameInMap("DataSourceRemark")]
            [Validation(Required=false)]
            public string DataSourceRemark { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>obs: Huawei Cloud OBS.</para>
            /// </description></item>
            /// <item><description><para>wafApi: Tencent Cloud WAF download API.</para>
            /// </description></item>
            /// <item><description><para>ckafka: Tencent Cloud CKafka.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>obs</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>The number of logs added to the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LogCount")]
            [Validation(Required=false)]
            public int? LogCount { get; set; }

            /// <summary>
            /// <para>The number of log collection tasks created for the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

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
