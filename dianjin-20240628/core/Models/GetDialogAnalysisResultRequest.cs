// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDialogAnalysisResultRequest : TeaModel {
        /// <summary>
        /// <para>Whether to sort in ascending order. Default is true, which sorts by session creation time in ascending order. If false, sorts in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The end time, which must be in yyyy-MM-dd HH:mm:ss format. If sessionIds are provided, the system queries session analysis results based on these IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-23 09:20:02</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Session ID list. When useUrl is true, the response includes OSS URLs. You can specify up to 1000 sessions. If you specify more than 1000, only the first 1000 are processed. When useUrl is false, the response includes full analysis results. You can specify up to 10 sessions. If you specify more than 10, only the first 10 are processed. This parameter is optional. If sessionIds is empty, the API retrieves results for sessions created between startTime and endTime. If sessionIds is not empty, the API retrieves results for the specified sessions. You cannot leave both sessionIds and the time range empty.</para>
        /// </summary>
        [NameInMap("sessionIds")]
        [Validation(Required=false)]
        public List<string> SessionIds { get; set; }

        /// <summary>
        /// <para>Start time in yyyy-MM-dd HH:mm:ss format. If sessionIds is not empty, you can query the session analysis results using the specified session IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-14 09:11:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Whether to return an OSS URL instead of full analysis results. If true, the response includes an OSS URL that expires in one hour. Default is true. Supports up to 1000 sessions. If you specify more than 1000, only the first 1000 are processed. If false, the response includes full analysis results. Supports up to 10 sessions. If you specify more than 10, only the first 10 are processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("useUrl")]
        [Validation(Required=false)]
        public bool? UseUrl { get; set; }

    }

}
