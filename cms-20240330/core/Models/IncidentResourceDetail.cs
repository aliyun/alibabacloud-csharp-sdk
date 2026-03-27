// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResourceDetail : TeaModel {
        /// <summary>
        /// <para>Additional resource identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-prod-web-01</para>
        /// </summary>
        [NameInMap("extraId")]
        [Validation(Required=false)]
        public string ExtraId { get; set; }

        /// <summary>
        /// <para>Resource ID object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;type&quot;: &quot;ecs&quot;, &quot;id&quot;: &quot;i-bp1234567890abcdef&quot; }</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceId { get; set; }

        /// <summary>
        /// <para>Resource type, indicating which cloud product the resource belongs to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
