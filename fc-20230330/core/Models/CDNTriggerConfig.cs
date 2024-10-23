// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CDNTriggerConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CdnDomainStarted</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("eventVersion")]
        [Validation(Required=false)]
        public string EventVersion { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Filter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>缓存事件触发器</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

    }

}
