// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class AttachGatewayDomainShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The custom domain name information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CustomDomain")]
        [Validation(Required=false)]
        public string CustomDomainShrink { get; set; }

    }

}
