// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListInstanceCountRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The type of the instance. Valid values: ZooKeeper and Nacos-Ans.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The edition type of the instance. Valid values:
        /// 
        /// *   `mse_dev`: Developer Edition
        /// *   `mse_pro`: Professional Edition
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

        /// <summary>
        /// The ID of the region where the instance resides. Examples:
        /// 
        /// *   cn-hangzhou: China (Hangzhou)
        /// *   cn-beijing: China (Beijing)
        /// *   cn-shanghai: China (Shanghai)
        /// *   cn-zhangjiakou: China (Zhangjiakou)
        /// *   cn-shenzhen: China (Shenzhen)
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

    }

}
