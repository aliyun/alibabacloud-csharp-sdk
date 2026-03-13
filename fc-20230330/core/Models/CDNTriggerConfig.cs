// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CDNTriggerConfig : TeaModel {
        /// <summary>
        /// <para>The name of the trigger event. For more information, see <a href="https://help.aliyun.com/document_detail/2513636.html">CDN events</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CdnDomainStarted</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The version of the trigger event. Only the 1.0.0 event version is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("eventVersion")]
        [Validation(Required=false)]
        public string EventVersion { get; set; }

        /// <summary>
        /// <para>The details of the event filtering rules.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Filter { get; set; }

        /// <summary>
        /// <para>The description of the trigger.</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

    }

}
