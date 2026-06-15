// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushStatByMsgRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The ID of the pushed message. This ID is returned after a message is pushed.</para>
        /// <remarks>
        /// <para>Push data is available the next day. You cannot query data for the current day.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>510427</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public long? MessageId { get; set; }

    }

}
