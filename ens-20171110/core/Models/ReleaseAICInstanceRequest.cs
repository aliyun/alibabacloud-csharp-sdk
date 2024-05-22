// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ReleaseAICInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

    }

}
