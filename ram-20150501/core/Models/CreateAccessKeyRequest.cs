// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateAccessKeyRequest : TeaModel {
        /// <summary>
        /// The name of the RAM user. If a RAM user calls this operation and does not specify this parameter, an AccessKey pair is created for the RAM user.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
