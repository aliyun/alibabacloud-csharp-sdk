// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EventResourceForEventView : TeaModel {
        [NameInMap("entity")]
        [Validation(Required=false)]
        public EventResourceForEventViewEntity Entity { get; set; }
        public class EventResourceForEventViewEntity : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;ECS&quot;</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;i-bp123456&quot;</para>
            /// </summary>
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;Instance&quot;</para>
            /// </summary>
            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;name&quot;: &quot;web-server-01&quot;, &quot;ip&quot;: &quot;10.0.0.1&quot; }</para>
            /// </summary>
            [NameInMap("prop")]
            [Validation(Required=false)]
            public Dictionary<string, object> Prop { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;env&quot;: &quot;prod&quot;, &quot;project&quot;: &quot;payment-gateway&quot; }</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
