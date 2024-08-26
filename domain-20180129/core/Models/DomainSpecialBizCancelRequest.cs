// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class DomainSpecialBizCancelRequest : TeaModel {
        /// <summary>
        /// The business ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public long? BizId { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
