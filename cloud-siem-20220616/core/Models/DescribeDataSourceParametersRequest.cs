// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceParametersRequest : TeaModel {
        /// <summary>
        /// The code of the cloud service provider.
        /// 
        /// Valid values:
        /// 
        /// *   qcloud
        /// *   hcloud
        /// *   aliyun
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ckafka**: Tencent Cloud TDMQ for CKafka
        /// *   **obs**: Huawei Cloud Object Storage Service (OBS)
        /// *   **wafApi**: download API of Tencent Cloud Web Application Firewall (WAF)
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
