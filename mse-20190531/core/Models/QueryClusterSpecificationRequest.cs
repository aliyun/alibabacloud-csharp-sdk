// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterSpecificationRequest : TeaModel {
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
        /// The network type. Valid values:
        /// 
        /// *   slb
        /// *   eni
        /// </summary>
        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        /// <summary>
        /// The edition of the Microservices Engine (MSE) instance that you want to purchase.
        /// 
        /// *   mse_pro: Professional Edition
        /// *   mse_dev: Developer Edition
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

    }

}
