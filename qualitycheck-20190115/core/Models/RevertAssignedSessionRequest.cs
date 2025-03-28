// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RevertAssignedSessionRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;isSchemeData&quot;:1,&quot;searchParam&quot;:{&quot;schemeTaskConfigId&quot;:1,&quot;sourceDataType&quot;:1,&quot;startTime&quot;:&quot;2022-09-20 00:00:00&quot;,&quot;endTime&quot;:&quot;2022-09-26 23:59:59&quot;}}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
