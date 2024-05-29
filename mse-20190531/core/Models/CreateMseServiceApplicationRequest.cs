// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateMseServiceApplicationRequest : TeaModel {
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
        /// The name of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The additional information.
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// The programming language of the application.
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The edition of the MSE instance that you want to purchase.
        /// 
        /// *   mse_pro: Professional Edition.
        /// *   mse_dev: Developer Edition.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// Specifies whether to enable the Sentinel-compatible mode.
        /// </summary>
        [NameInMap("SentinelEnable")]
        [Validation(Required=false)]
        public string SentinelEnable { get; set; }

        /// <summary>
        /// The service source.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// Specifies whether to enable switching.
        /// </summary>
        [NameInMap("SwitchEnable")]
        [Validation(Required=false)]
        public string SwitchEnable { get; set; }

    }

}
