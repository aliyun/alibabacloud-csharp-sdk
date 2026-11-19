// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryAuditLogRequest : TeaModel {
        /// <summary>
        /// <para>The access source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMMON: Regular access.</description></item>
        /// <item><description>IMBEDDED: Embedded report.</description></item>
        /// <item><description>PUBLIC: Public report.</description></item>
        /// <item><description>IMBEDDED_COMPONENT: Embedded card.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AccessSourceFlag")]
        [Validation(Required=false)]
        public string AccessSourceFlag { get; set; }

        /// <summary>
        /// <para>The end date of the query. Format: yyyyMMdd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240604</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dataView: Access.</description></item>
        /// <item><description>function: Operation.</description></item>
        /// <item><description>permission: Permission.</description></item>
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
        /// <para>The user ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0***</para>
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>The permission, access, or operation type. If this parameter is left empty, all types are queried by default. For more information, see the audit log code values. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODIFY</para>
        /// </summary>
        [NameInMap("OperatorTypes")]
        [Validation(Required=false)]
        public string OperatorTypes { get; set; }

        /// <summary>
        /// <para>The resource type. For more information, see the asset type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cube</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The start date of the query. Format: yyyyMMdd. The date cannot be more than 90 days before the current date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240504</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The access device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MOBILE: Mobile client.</description></item>
        /// <item><description>PC: PC client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserAccessDevice")]
        [Validation(Required=false)]
        public string UserAccessDevice { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the logs to be queried belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
