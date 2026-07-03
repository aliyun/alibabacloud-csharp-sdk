// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for the export task. The value is a JSON string that is generated based on the query conditions.</para>
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
        /// <para>The type of data to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>incident_list: event list.</description></item>
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
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
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
        /// <para>The region of the Data Management center. Select a region based on where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: The Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Regions outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of a member. An administrator can use this parameter to switch to the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
