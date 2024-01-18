// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAccountsByLogRequest : TeaModel {
        /// <summary>
        /// The code that is used for multi-cloud environments.
        /// 
        /// Valid values:
        /// 
        /// *   qcloud
        /// *   hcloud
        /// *   aliyun
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// The codes of logs. The value is a JSON array.
        /// </summary>
        [NameInMap("LogCodes")]
        [Validation(Required=false)]
        public List<string> LogCodes { get; set; }

        /// <summary>
        /// The code of the service.
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
