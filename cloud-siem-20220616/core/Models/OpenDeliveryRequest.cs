// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class OpenDeliveryRequest : TeaModel {
        /// <summary>
        /// The log code of the cloud service, such as the code of the process log for Security Center. This parameter is optional. If you leave this parameter empty, operations are performed on all logs of the cloud service.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the account that you switch from the management account.
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// The type of the view. Valid values:
        /// - 0: the current Alibaba Cloud account
        /// - 1: the global account
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
