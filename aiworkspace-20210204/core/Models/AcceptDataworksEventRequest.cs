// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class AcceptDataworksEventRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;eventCode&quot;:&quot;d<em><em><b>ct&quot;,&quot;projectId&quot;:&quot;8</b></em>6&quot;,&quot;tenantId&quot;:4</em>*<em><b><b>8,&quot;operator&quot;:&quot;115</b></b></em>901&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>539306ba-*****-41a0-****-6dc81060985c</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
