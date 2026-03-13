// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class OSSTriggerConfig : TeaModel {
        /// <summary>
        /// <para>The list of events. Enter an event related to OSS. For more information about event types,see <a href="https://help.aliyun.com/document_detail/2513613.html">OSS events</a>.</para>
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// <para>The event filtering rule.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Filter Filter { get; set; }

    }

}
