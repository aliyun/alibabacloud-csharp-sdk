// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class OrderClusterHealthCheckRiskNoticeRequest : TeaModel {
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
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to disable the risk item notification feature.
        /// 
        /// *   true: disabled
        /// *   false: enabled
        /// </summary>
        [NameInMap("Mute")]
        [Validation(Required=false)]
        public bool? Mute { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public string NoticeType { get; set; }

        /// <summary>
        /// The region in which the cluster resides.
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

        /// <summary>
        /// The code of the risk.
        /// </summary>
        [NameInMap("RiskCode")]
        [Validation(Required=false)]
        public string RiskCode { get; set; }

    }

}
