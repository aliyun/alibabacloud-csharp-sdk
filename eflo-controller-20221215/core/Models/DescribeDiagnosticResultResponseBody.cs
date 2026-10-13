// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeDiagnosticResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118913031696573280136</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The time when the device was created. The time is in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-15T10:17:56</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The diagnostic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>diag-i155363241720059671316</para>
        /// </summary>
        [NameInMap("DiagnosticId")]
        [Validation(Required=false)]
        public string DiagnosticId { get; set; }

        /// <summary>
        /// <para>The diagnostic information.</para>
        /// </summary>
        [NameInMap("DiagnosticResults")]
        [Validation(Required=false)]
        public List<object> DiagnosticResults { get; set; }

        /// <summary>
        /// <para>The diagnostic status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fault</para>
        /// </summary>
        [NameInMap("DiagnosticState")]
        [Validation(Required=false)]
        public string DiagnosticState { get; set; }

        /// <summary>
        /// <para>The diagnostic type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CheckByAiJobLogs</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// <para>The time when the node exception ended. The time is in ISO 8601 format with a time zone, in the yyyy-MM-ddTHH:mm:ss+0800 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-11T10:00:30</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of node IDs.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F065DDD-6996-5973-9691-9EC57BD0072E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
