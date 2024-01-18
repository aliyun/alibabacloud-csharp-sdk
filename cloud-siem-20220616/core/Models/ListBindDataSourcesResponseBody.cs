// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListBindDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBindDataSourcesResponseBodyData> Data { get; set; }
        public class ListBindDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The username of the cloud account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The code of the cloud service provider. Valid values:
            /// 
            /// *   qcloud: Tencent Cloud
            /// *   aliyun: Alibaba Cloud
            /// *   hcloud: Huawei Cloud
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// The ID of the data source. The ID is an MD5 hash value that is calculated by the threat analysis feature based on specific parameters.
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            /// <summary>
            /// The name of the data source.
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// The remarks on the data source.
            /// </summary>
            [NameInMap("DataSourceRemark")]
            [Validation(Required=false)]
            public string DataSourceRemark { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   obs: Huawei Cloud Object Storage Service (OBS)
            /// *   wafApi: download API of Tencent Cloud Web Application Firewall (WAF)
            /// *   ckafka: Tencent Cloud Kafka (CKafka)
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// The number of logs that are added within the data source.
            /// </summary>
            [NameInMap("LogCount")]
            [Validation(Required=false)]
            public int? LogCount { get; set; }

            /// <summary>
            /// The number of existing tasks that are created to add logs within the data source.
            /// </summary>
            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
