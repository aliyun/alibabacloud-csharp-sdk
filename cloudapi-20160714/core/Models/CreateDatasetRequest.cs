// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// Dataset Name
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// The type of the dataset. Valid values:
        /// 
        /// *   JWT_BLOCKING: a JSON Web Token (JWT) blacklist
        /// *   IP_WHITELIST_CIDR : an IP address whitelist
        /// *   PARAMETER_ACCESS : parameter-based access control
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
