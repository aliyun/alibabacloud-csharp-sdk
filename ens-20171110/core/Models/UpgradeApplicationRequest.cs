// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UpgradeApplicationRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The information template for phased update. The value must be a JSON string and contain the following information:
        /// 
        /// *   Version range that you want to update
        /// *   Configuration information of the target version
        /// *   Canary release policy for resources
        /// *   Intelligent upgrade policy that contains information such as the time window and resource usage limit
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// The timeout period for asynchronous upgrade. Unit: seconds. Default value: 300.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
