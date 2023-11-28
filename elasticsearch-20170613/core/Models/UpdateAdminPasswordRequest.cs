// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateAdminPasswordRequest : TeaModel {
        [NameInMap("esAdminPassword")]
        [Validation(Required=false)]
        public string EsAdminPassword { get; set; }

        /// <summary>
        /// Indicates whether the password was updated. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
