// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddDataSourceLogRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud account.
        /// 
        /// This parameter is required.
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
        /// The ID of the data source. The ID is an MD5 hash value that is calculated by the threat analysis feature based on specific parameters. You can call the [ListDataSourceLogs](https://api.aliyun-inc.com/#/publishment/document/cloud-siem/863fdf54478f4cc5877e27c2a5fe9e44?tenantUuid=f382fccd88b94c5c8c864def6815b854\\&activeTabKey=api%7CListDataSourceLogs) operation to query the IDs of data sources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceInstanceId")]
        [Validation(Required=false)]
        public string DataSourceInstanceId { get; set; }

        /// <summary>
        /// The parameters of the data source. Set this parameter to a JSON array.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceInstanceLogs")]
        [Validation(Required=false)]
        public string DataSourceInstanceLogs { get; set; }

        /// <summary>
        /// The log code.
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

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
