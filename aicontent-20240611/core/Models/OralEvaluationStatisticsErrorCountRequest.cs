// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OralEvaluationStatisticsErrorCountRequest : TeaModel {
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
        /// <para>End time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-22 06:24:53</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>List of error codes</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public List<string> ErrorCode { get; set; }

        /// <summary>
        /// <para>Query granularity (Hour, Day, Month)</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>Project ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-27 09:32:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
