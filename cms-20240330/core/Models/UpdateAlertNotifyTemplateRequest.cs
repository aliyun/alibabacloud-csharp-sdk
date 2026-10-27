// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAlertNotifyTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("alertNotifyTemplateName")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;zh&quot;:{&quot;title&quot;:&quot;云监控报警: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>报警标题:</b> {{.incident.title}}\n<b>级别:</b> {{.incident.severity}}\n<b>事件数:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:&quot;{\&quot;IncidentCreationNotify\&quot;:{\&quot;title\&quot;:\&quot;云监控报警: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>报警标题:</b> {{.incident.title}}\\n<b>级别:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true},\&quot;IncidentResolutionNotify\&quot;:{\&quot;title\&quot;:\&quot;云监控报警已解决: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>报警标题:</b> {{.incident.title}}\\n<b>级别:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true}}&quot;},&quot;en&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}\n<b>Events:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:&quot;{\&quot;IncidentCreationNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true},\&quot;IncidentResolutionNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert Resolved: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true}}&quot;}}</para>
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Templates { get; set; }

    }

}
