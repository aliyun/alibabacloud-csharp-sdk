// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTicketsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;totalResults&quot;:1 &quot;previousPage&quot;:1 &quot;data&quot;:[ 0:{ &quot;serviceType&quot;:1 &quot;lastUrgeTime&quot;:0 &quot;queueId&quot;:0 &quot;sopCateId&quot;:252011 &quot;totalUrgeMemo&quot;:&quot;&quot; &quot;taskGmtModified&quot;:0 &quot;departmentId&quot;:10 &quot;groupId&quot;:0 &quot;channelType&quot;:1 &quot;questionInfo&quot;:&quot;&quot; &quot;templateId&quot;:0 &quot;deadLine&quot;:0 &quot;srType&quot;:30701 &quot;caseId&quot;:2000000001165962}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
