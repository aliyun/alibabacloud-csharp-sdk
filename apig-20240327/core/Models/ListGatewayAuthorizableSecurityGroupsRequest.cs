// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayAuthorizableSecurityGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Container Service cluster. Only security groups associated with the cluster are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4a21b3560fad4ec299f3e63f4***</para>
        /// </summary>
        [NameInMap("csClusterId")]
        [Validation(Required=false)]
        public string CsClusterId { get; set; }

    }

}
