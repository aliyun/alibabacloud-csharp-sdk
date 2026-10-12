// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateNetworkAccessRequest : TeaModel {
        /// <summary>
        /// <para>The expected network access type after the change. For example, to add public network access to a private network gateway, set this parameter to private&amp;pubnet. To remove private network access from a gateway that supports both public and private network access, set this parameter to pubnet.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>privatenet: private network only.</description></item>
        /// <item><description>private&amp;pubnet: public network and private network.</description></item>
        /// <item><description>pubnet: public network only.</description></item>
        /// </list>
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
