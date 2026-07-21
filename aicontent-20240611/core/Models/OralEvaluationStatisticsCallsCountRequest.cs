// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OralEvaluationStatisticsCallsCountRequest : TeaModel {
        /// <summary>
        /// <para>appId,appkey</para>
        /// 
        /// <b>Example:</b>
        /// <para>a0007g7</para>
        /// </summary>
        [NameInMap("applicationAccessId")]
        [Validation(Required=false)]
        public string ApplicationAccessId { get; set; }

        /// <summary>
        /// <para>End Time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-15 07:40:01</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Query granularity (hour, Day, month)</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>project ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Start Time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-14 07:40:01</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
