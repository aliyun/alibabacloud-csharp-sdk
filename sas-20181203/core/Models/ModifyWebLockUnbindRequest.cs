// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockUnbindRequest : TeaModel {
        /// <summary>
        /// The UUID of the server for which you want to disable web tamper proofing.
        /// 
        /// > You can call the [DescribeWebLockBindList](~~DescribeWebLockBindList~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
