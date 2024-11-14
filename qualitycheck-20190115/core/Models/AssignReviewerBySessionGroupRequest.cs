// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class AssignReviewerBySessionGroupRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;sessionGroupParam&quot;:{&quot;isSchemeData&quot;:1,&quot;callStartTime&quot;:&quot;2022-09-17 00:00:00&quot;,&quot;callEndTime&quot;:&quot;2022-09-23 23:59:59&quot;,&quot;schemeTaskConfigId&quot;:24},&quot;assignments&quot;:[{&quot;reviewer&quot;:63,&quot;count&quot;:4}],&quot;isSchemeData&quot;:1}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
