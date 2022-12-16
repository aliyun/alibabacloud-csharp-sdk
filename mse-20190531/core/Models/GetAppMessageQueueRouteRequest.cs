// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetAppMessageQueueRouteRequest : TeaModel {
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
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The region where the cluster resides. Examples:
        /// 
        /// *   `cn-hangzhou`: China (Hangzhou)
        /// *   `cn-beijing`: China (Beijing)
        /// *   `cn-shanghai`: China (Shanghai)
        /// *   `cn-zhangjiakou`: China (Zhangjiakou)
        /// *   `cn-shenzhen`: China (Shenzhen)
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
