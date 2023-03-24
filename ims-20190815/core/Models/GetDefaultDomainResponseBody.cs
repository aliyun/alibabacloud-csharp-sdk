// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetDefaultDomainResponseBody : TeaModel {
        /// <summary>
        /// The default domain name.
        /// </summary>
        [NameInMap("DefaultDomainName")]
        [Validation(Required=false)]
        public string DefaultDomainName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
