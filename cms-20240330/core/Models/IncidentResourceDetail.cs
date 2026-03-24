// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResourceDetail : TeaModel {
        /// <summary>
        /// <para>额外的资源标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-prod-web-01</para>
        /// </summary>
        [NameInMap("extraId")]
        [Validation(Required=false)]
        public string ExtraId { get; set; }

        /// <summary>
        /// <para>资源 ID 对象。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;type&quot;: &quot;ecs&quot;, &quot;id&quot;: &quot;i-bp1234567890abcdef&quot; }</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceId { get; set; }

        /// <summary>
        /// <para>资源类型，表示该资源属于哪种云产品。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
