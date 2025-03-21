// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeDiagnosticResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i118913031696573280136</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-15T10:17:56</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>diag-i155363241720059671316</para>
        /// </summary>
        [NameInMap("DiagnosticId")]
        [Validation(Required=false)]
        public string DiagnosticId { get; set; }

        [NameInMap("DiagnosticResults")]
        [Validation(Required=false)]
        public List<object> DiagnosticResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Fault</para>
        /// </summary>
        [NameInMap("DiagnosticState")]
        [Validation(Required=false)]
        public string DiagnosticState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CheckByAiJobLogs</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-11T10:00:30</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8F065DDD-6996-5973-9691-9EC57BD0072E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
