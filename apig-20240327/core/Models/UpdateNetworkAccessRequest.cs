// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateNetworkAccessRequest : TeaModel {
        /// <summary>
        /// <para>The expected network access type after the modification. For example, if public network access is added to a private gateway, set this parameter to private&amp;pubnet. If private network access is removed from a gateway with both public and private network access, set this parameter to pubnet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private&amp;pubnet</para>
        /// </summary>
        [NameInMap("networkAccessType")]
        [Validation(Required=false)]
        public string NetworkAccessType { get; set; }

    }

}
