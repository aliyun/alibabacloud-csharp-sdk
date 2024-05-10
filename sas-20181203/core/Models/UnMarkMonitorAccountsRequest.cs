// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UnMarkMonitorAccountsRequest : TeaModel {
        /// <summary>
        /// The IDs of the members.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIds { get; set; }

    }

}
