// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListSystemLogsRequest : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("GmtEndTime")]
        [Validation(Required=false)]
        public string GmtEndTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("GmtStartTime")]
        [Validation(Required=false)]
        public string GmtStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dsw-730xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LifecycleId")]
        [Validation(Required=false)]
        public string LifecycleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Error</para>
        /// </summary>
        [NameInMap("LogLevel")]
        [Validation(Required=false)]
        public string LogLevel { get; set; }

        [NameInMap("LogRepository")]
        [Validation(Required=false)]
        public string LogRepository { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InstanceStartFailed</para>
        /// </summary>
        [NameInMap("ProblemCategory")]
        [Validation(Required=false)]
        public string ProblemCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-******5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("SourceRequestId")]
        [Validation(Required=false)]
        public string SourceRequestId { get; set; }

    }

}
