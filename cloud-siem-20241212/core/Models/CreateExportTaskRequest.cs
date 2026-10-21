// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The export task parameters, which are concatenated based on query conditions in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;IncidentName&quot;: &quot;name&quot;,
        ///     &quot;IncidentStatus&quot;: &quot;1&quot;,
        ///     &quot;ThreatLevel&quot;:[&quot;1&quot;,&quot;2&quot;],
        ///     &quot;IncidentUuids&quot;:&quot;315EE627-39DC-560A-8DFD-CBF66AD9****&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ExportTaskParameter")]
        [Validation(Required=false)]
        public string ExportTaskParameter { get; set; }

        /// <summary>
        /// <para>The export type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>incident_list: Event list.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>incident_list</para>
        /// </summary>
        [NameInMap("ExportTaskType")]
        [Validation(Required=false)]
        public string ExportTaskType { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.<remarks>
        /// <para>Note: This parameter is required. If you do not specify this parameter, the API returns a 400 error: &quot;The specified Lang can not be empty.&quot;</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the threat analysis data management center resides. Specify the management center region based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
