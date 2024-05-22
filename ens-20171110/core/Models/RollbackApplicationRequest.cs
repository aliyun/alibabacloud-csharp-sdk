// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RollbackApplicationRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The current version number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FromAppVersion")]
        [Validation(Required=false)]
        public string FromAppVersion { get; set; }

        /// <summary>
        /// The timeout period of the asynchronous rollback operation. Unit: seconds. Default value: 300.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The target version number. By default, the system automatically rolls back the container version to the previous version.
        /// </summary>
        [NameInMap("ToAppVersion")]
        [Validation(Required=false)]
        public string ToAppVersion { get; set; }

    }

}
