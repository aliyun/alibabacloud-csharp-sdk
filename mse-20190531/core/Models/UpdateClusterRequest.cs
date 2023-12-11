// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateClusterRequest : TeaModel {
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
        /// The alias of the instance.
        /// </summary>
        [NameInMap("ClusterAliasName")]
        [Validation(Required=false)]
        public string ClusterAliasName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The end time of the O\&M window.
        /// </summary>
        [NameInMap("MaintenanceEndTime")]
        [Validation(Required=false)]
        public string MaintenanceEndTime { get; set; }

        /// <summary>
        /// The start time of the O\&M window.
        /// </summary>
        [NameInMap("MaintenanceStartTime")]
        [Validation(Required=false)]
        public string MaintenanceStartTime { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

    }

}
