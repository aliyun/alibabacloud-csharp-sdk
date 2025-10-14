// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateExportTaskRequest : TeaModel {
        /// <summary>
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
        /// <b>Example:</b>
        /// <para>incident_list</para>
        /// </summary>
        [NameInMap("ExportTaskType")]
        [Validation(Required=false)]
        public string ExportTaskType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
