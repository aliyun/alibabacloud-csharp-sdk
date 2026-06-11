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
        /// <item><description><para>COMMON: standard access</para>
        /// </description></item>
        /// <item><description><para>IMBEDDED: embedded report</para>
        /// </description></item>
        /// <item><description><para>PUBLIC: public report</para>
        /// </description></item>
        /// <item><description><para>IMBEDDED_COMPONENT: embedded card</para>
        /// </description></item>
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
        /// <para>The end date for the query. Use the yyyyMMdd format.</para>
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
        /// <item><description><para>dataView: access logs</para>
        /// </description></item>
        /// <item><description><para>function: operation logs</para>
        /// </description></item>
        /// <item><description><para>permission: permission logs</para>
        /// </description></item>
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
        /// <para>The permission, access, or operation type. If left empty, all types are queried by default.</para>
        /// <para>For valid values, see audit log codes. To specify multiple types, separate them with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODIFY</para>
        /// </summary>
        [NameInMap("OperatorTypes")]
        [Validation(Required=false)]
        public string OperatorTypes { get; set; }

        /// <summary>
        /// <para>The resource type. For more information, see work types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cube</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The start date for the query. Use the yyyyMMdd format. The date cannot be more than 90 days before the current date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240504</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The device used for access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MOBILE: mobile device</para>
        /// </description></item>
        /// <item><description><para>PC: PC</para>
        /// </description></item>
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
        /// <para>The ID of the workspace that contains the logs to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
