// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class BatchSubmitReviewInfoRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;isSchemeData&quot;:1,&quot;schemeTaskConfigId&quot;:334,&quot;sourceDataType&quot;:2,&quot;startTime&quot;:&quot;2022-08-25 00:00:00&quot;,&quot;endTime&quot;:&quot;2022-09-23 23:59:59&quot;,&quot;sessionList&quot;:[{&quot;taskId&quot;:&quot;20220831-F8D7F4DF-0A16-1A1C-BA63-28F203922692&quot;,&quot;fileId&quot;:&quot;20220831-164343&quot;},{&quot;taskId&quot;:&quot;20220831-F2A50A72-82C4-1E3F-A1FD-52A662283D25&quot;,&quot;fileId&quot;:&quot;20220831-164343&quot;}]}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
