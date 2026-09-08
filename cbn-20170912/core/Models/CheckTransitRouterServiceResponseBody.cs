// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CheckTransitRouterServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the transit router service is activated for the current Alibaba Cloud account.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The service is activated.</description></item>
        /// <item><description>If this parameter is not returned, the transit router service is not activated for the current Alibaba Cloud account, and the system returns a corresponding message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D93C8B9-C354-5C3E-BEFB-BA8A2C314D68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
