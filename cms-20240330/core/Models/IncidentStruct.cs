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
        /// <para>检测到 RDS 实例 rds-bp1234567890abcdef 的连接数达到 1000，已触发告警。</para>
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
        /// <para>数据库连接数过高</para>
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
