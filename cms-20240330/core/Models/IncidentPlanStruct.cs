// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanStruct : TeaModel {
        /// <summary>
        /// <para>The wait time for automatic recovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public int? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>The timeout period for closing the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("closeExpire")]
        [Validation(Required=false)]
        public long? CloseExpire { get; set; }

        /// <summary>
        /// <para>The list of teams or roles involved in the collaboration.</para>
        /// </summary>
        [NameInMap("corporation")]
        [Validation(Required=false)]
        public List<IncidentPlanCorporationStruct> Corporation { get; set; }

        /// <summary>
        /// <para>The plan description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Emergency response plan for excessive database connections</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of escalation policy IDs.</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The grouping field path.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> GroupBy { get; set; }

        /// <summary>
        /// <para>The incident plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-001</para>
        /// </summary>
        [NameInMap("incidentPlanId")]
        [Validation(Required=false)]
        public string IncidentPlanId { get; set; }

        /// <summary>
        /// <para>The plan name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Incident plan for database connection alerts</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of resource field mapping paths.</para>
        /// </summary>
        [NameInMap("resourceFiled")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> ResourceFiled { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
