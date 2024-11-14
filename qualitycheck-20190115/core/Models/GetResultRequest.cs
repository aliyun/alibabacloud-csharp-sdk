// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetResultRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;pageNumber&quot;:1,&quot;pageSize&quot;:10,&quot;excludeFields&quot;:&quot;hitResult.hits, recording.url&quot;,&quot;requiredFields&quot;:&quot;agent,status,errorMessage,reviewStatus,reviewResult,score,taskId,reviewer,resolver,recording.name,recording.duration,hitResult,business&quot;,&quot;dataType&quot;:1,&quot;sourceType&quot;:0,&quot;startTime&quot;:&quot;2020-06-25 00:00:00&quot;,&quot;endTime&quot;:&quot;2020-07-01 23:59:59&quot;}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
