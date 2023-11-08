// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUserPermissionsRequest : TeaModel {
        /// <summary>
        /// The ID of a RAM user or RAM role.
        /// </summary>
        [NameInMap("SubAccountUserId")]
        [Validation(Required=false)]
        public string SubAccountUserId { get; set; }

    }

}
