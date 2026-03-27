// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanStruct : TeaModel {
        /// <summary>
        /// <para>Automatic recovery wait time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public int? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>Event closure timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("closeExpire")]
        [Validation(Required=false)]
        public long? CloseExpire { get; set; }

        /// <summary>
        /// <para>List of teams or roles involved in collaboration.</para>
        /// </summary>
        [NameInMap("corporation")]
        [Validation(Required=false)]
        public List<IncidentPlanCorporationStruct> Corporation { get; set; }

        /// <summary>
        /// <para>Contingency plan description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Emergency response plan for excessively high database connection count.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>List of escalation policy IDs.</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>Creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>Last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>Grouping field path.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> GroupBy { get; set; }

        /// <summary>
        /// <para>Event contingency plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-001</para>
        /// </summary>
        [NameInMap("incidentPlanId")]
        [Validation(Required=false)]
        public string IncidentPlanId { get; set; }

        /// <summary>
        /// <para>Contingency plan name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Database connection count alert contingency plan.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>List of resource field mapping paths.</para>
        /// </summary>
        [NameInMap("resourceFiled")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> ResourceFiled { get; set; }

        /// <summary>
        /// <para>Status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uesr-12345</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// <para>Workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
