// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GetAccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mod-kw1750tjqs94n9k37o5hjk</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource name of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COUPON_OPERATION_CALLBACK</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SceneTestingTask</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
