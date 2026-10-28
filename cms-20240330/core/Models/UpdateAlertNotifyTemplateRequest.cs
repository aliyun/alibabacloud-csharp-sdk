// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAlertNotifyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the notification template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("alertNotifyTemplateName")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateName { get; set; }

        /// <summary>
        /// <para>The multilingual notification templates. The key is the language code: zh for Chinese and en for English. The value is the template configuration object for the specified language. When a notification is sent, the corresponding template is selected based on the recipient\&quot;s language. The body format varies by type: Markdown for DING, WEIXIN, and FEISHU; HTML for EMAIL; plain text for SMS, CALL, and SLACK; and JSON for CUSTOM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;zh&quot;:{&quot;title&quot;:&quot;云监控报警: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>报警标题:</b> {{.incident.title}}\n<b>级别:</b> {{.incident.severity}}\n<b>事件数:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:&quot;{\&quot;IncidentCreationNotify\&quot;:{\&quot;title\&quot;:\&quot;云监控报警: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>报警标题:</b> {{.incident.title}}\\n<b>级别:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true},\&quot;IncidentResolutionNotify\&quot;:{\&quot;title\&quot;:\&quot;云监控报警已解决: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>报警标题:</b> {{.incident.title}}\\n<b>级别:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true}}&quot;},&quot;en&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}\n<b>Events:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:&quot;{\&quot;IncidentCreationNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true},\&quot;IncidentResolutionNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert Resolved: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true}}&quot;}}</para>
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Templates { get; set; }

    }

}
