// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryTracedEventByEventIdRequest : TeaModel {
        /// <summary>
        /// <para>The name of the event bus.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1935debf-ddac-49dc-a090-d4f2857a046d</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The name of the event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse</para>
        /// </summary>
        [NameInMap("EventSource")]
        [Validation(Required=false)]
        public string EventSource { get; set; }

    }

}
