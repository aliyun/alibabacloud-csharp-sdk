// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ParentResourceInfo : TeaModel {
        /// <summary>
        /// <para>The API information.</para>
        /// </summary>
        [NameInMap("apiInfo")]
        [Validation(Required=false)]
        public HttpApiApiInfo ApiInfo { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HttpApi</description></item>
        /// <item><description>Operation</description></item>
        /// <item><description>GatewayRoute</description></item>
        /// <item><description>Gateway</description></item>
        /// <item><description>GatewayDomain</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Gateway</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
