// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateCustomDomainRequest : TeaModel {
        /// <summary>
        /// The information about the custom domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateCustomDomainInput Body { get; set; }

    }

}
