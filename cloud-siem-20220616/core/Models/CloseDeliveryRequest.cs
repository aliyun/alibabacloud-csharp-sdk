// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class CloseDeliveryRequest : TeaModel {
        /// <summary>
        /// The log code of the cloud service, such as the code of the process log for Security Center. You can obtain the log code from the response of the ListDelivery operation.
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// The code of the cloud service. Valid values:
        /// 
        /// *   qcloud_waf
        /// *   qlcoud_cfw
        /// *   hcloud_waf
        /// *   hcloud_cfw
        /// *   ddos
        /// *   sas
        /// *   cfw
        /// *   config
        /// *   csk
        /// *   fc
        /// *   rds
        /// *   nas
        /// *   apigateway
        /// *   cdn
        /// *   mongodb
        /// *   eip
        /// *   slb
        /// *   vpc
        /// *   actiontrail
        /// *   waf
        /// *   bastionhost
        /// *   oss
        /// *   polardb
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside the Chinese mainland or in the China (Hong Kong) region.
        /// *   ap-southeast-1: Your assets reside in regions outside the Chinese mainland, excluding the China (Hong Kong) region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
