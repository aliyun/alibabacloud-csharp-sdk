// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetChatContentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PLAN</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("checkpoint")]
        [Validation(Required=false)]
        public long? Checkpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Data understanding completed.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>str</para>
        /// </summary>
        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DATA</para>
        /// </summary>
        [NameInMap("event_type")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

    }

}
