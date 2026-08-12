// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentStruct : TeaModel {
        /// <summary>
        /// <para>The content of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Detected that the connection count of RDS instance rds-bp1234567890abcdef has reached 1000, triggering an alert.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The list of escalation policies.</para>
        /// </summary>
        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<IncidentEscalationStruct> Escalations { get; set; }

        /// <summary>
        /// <para>The unique ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>The associated incident plan.</para>
        /// </summary>
        [NameInMap("incidentPlan")]
        [Validation(Required=false)]
        public IncidentPlanStruct IncidentPlan { get; set; }

        /// <summary>
        /// <para>The details of the associated resource.</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public IncidentResourceDetail Resource { get; set; }

        /// <summary>
        /// <para>The severity level of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P1</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The current status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The title of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Excessively high database connection count.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
