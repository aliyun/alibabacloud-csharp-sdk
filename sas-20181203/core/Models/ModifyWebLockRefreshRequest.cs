// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockRefreshRequest : TeaModel {
        /// <summary>
        /// The UUID of the server for which you want to refresh the status of the web tamper proofing feature.
        /// 
        /// >  You can call the [DescribeWebLockBindList](~~DescribeWebLockBindList~~) operation to query the servers for which the web tamper proofing feature is enabled.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
