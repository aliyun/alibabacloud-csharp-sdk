// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EventResourceForIncidentView : TeaModel {
        /// <summary>
        /// <para>The domain of the resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rum</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("entityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Instance&quot;</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The string that describes the properties of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;name&quot;:&quot;web-server-01&quot;,&quot;ip&quot;:&quot;10.0.0.1&quot;}&quot;</para>
        /// </summary>
        [NameInMap("probs")]
        [Validation(Required=false)]
        public string Probs { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;value\&quot;:\&quot;测试\&quot;,\&quot;key\&quot;:\&quot;环境\&quot;}]</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
