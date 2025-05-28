// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryAuditLogRequest : TeaModel {
        /// <summary>
        /// <para>End date of the query, format (&quot;yyyyMMdd&quot;).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240604</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Log type:</para>
        /// <list type="bullet">
        /// <item><description>dataView - Access</description></item>
        /// <item><description>function - Operation</description></item>
        /// <item><description>permission - Permission</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>function</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>Operator\&quot;s user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0***</para>
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>Permission/Access/Operation type, empty - default all;</para>
        /// <para>Refer to the audit log code values, send multiple values separated by English commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODIFY</para>
        /// </summary>
        [NameInMap("OperatorTypes")]
        [Validation(Required=false)]
        public string OperatorTypes { get; set; }

        /// <summary>
        /// <para>Resource type, refer to the work type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cube</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Start date of the query, format (&quot;yyyyMMdd&quot;), cannot be earlier than 90 days from the current time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240504</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>Workspace ID, the ID of the workspace to which the logs to be queried belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
