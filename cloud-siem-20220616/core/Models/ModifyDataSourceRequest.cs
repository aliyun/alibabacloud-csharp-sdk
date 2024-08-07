// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ModifyDataSourceRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud account.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The code of the cloud service provider. Valid values:
        /// 
        /// *   qcloud: Tencent Cloud
        /// *   aliyun: Alibaba Cloud
        /// *   hcloud: Huawei Cloud
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// The ID of the data source. The ID is an MD5 hash value that is calculated by the threat analysis feature based on specific parameters. You can call the [DescribeDataSourceInstance](https://api.aliyun-inc.com/#/publishment/document/cloud-siem/863fdf54478f4cc5877e27c2a5fe9e44?tenantUuid=f382fccd88b94c5c8c864def6815b854\\&activeTabKey=api%7CDescribeDataSourceInstance) operation to query the IDs of data sources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceInstanceId")]
        [Validation(Required=false)]
        public string DataSourceInstanceId { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("DataSourceInstanceName")]
        [Validation(Required=false)]
        public string DataSourceInstanceName { get; set; }

        /// <summary>
        /// The parameters of the data source in the JSON string format.
        /// </summary>
        [NameInMap("DataSourceInstanceParams")]
        [Validation(Required=false)]
        public string DataSourceInstanceParams { get; set; }

        /// <summary>
        /// The remarks on the data source.
        /// </summary>
        [NameInMap("DataSourceInstanceRemark")]
        [Validation(Required=false)]
        public string DataSourceInstanceRemark { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   ckafka: Tencent Cloud Kafka (CKafka)
        /// *   obs: Huawei Cloud Object Storage Service (OBS)
        /// *   wafApi: download API of Tencent Cloud Web Application Firewall (WAF)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
