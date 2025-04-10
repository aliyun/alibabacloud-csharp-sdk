// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeDiagnosticResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118913031696573280136</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Device creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-15T10:17:56</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>Diagnostic ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>diag-i155363241720059671316</para>
        /// </summary>
        [NameInMap("DiagnosticId")]
        [Validation(Required=false)]
        public string DiagnosticId { get; set; }

        /// <summary>
        /// <para>Diagnostic Information</para>
        /// </summary>
        [NameInMap("DiagnosticResults")]
        [Validation(Required=false)]
        public List<object> DiagnosticResults { get; set; }

        /// <summary>
        /// <para>Diagnostic State</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fault</para>
        /// </summary>
        [NameInMap("DiagnosticState")]
        [Validation(Required=false)]
        public string DiagnosticState { get; set; }

        /// <summary>
        /// <para>Diagnostic Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>CheckByAiJobLogs</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// <para>End time of node anomaly issues. Represented according to the ISO8601 standard, in a timezone-aware format, formatted as yyyy-MM-ddTHH:mm:ss+0800</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-11T10:00:30</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>List of Node IDs</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F065DDD-6996-5973-9691-9EC57BD0072E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
