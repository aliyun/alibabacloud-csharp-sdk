// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAlertNotifyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the notification template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("alertNotifyTemplateId")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateId { get; set; }

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
        /// <para>The template syntax type. Currently, only Go is supported. Templates in the title and content fields use the Go template syntax.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GO</para>
        /// </summary>
        [NameInMap("programLang")]
        [Validation(Required=false)]
        public string ProgramLang { get; set; }

        /// <summary>
        /// <para>The multilingual notification templates. The key is the language code: zh for Chinese and en for English. The value is the template configuration object for the specified language. When a notification is sent, the corresponding template is selected based on the recipient\&quot;s language. The content format varies by type: Markdown for DING, WEIXIN, and FEISHU; HTML for EMAIL; plain text for SMS, CALL, and SLACK; and JSON for CUSTOM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;zh&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}\n<b>Events:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:&quot;{\&quot;IncidentCreationNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true},\&quot;IncidentResolutionNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert Resolved: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true}}&quot;},&quot;en&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}\n<b>Events:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:&quot;{\&quot;IncidentCreationNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true},\&quot;IncidentResolutionNotify\&quot;:{\&quot;title\&quot;:\&quot;CloudMonitor Alert Resolved: {{.incident.title}}\&quot;,\&quot;content\&quot;:\&quot;<b>Alert Title:</b> {{.incident.title}}\\n<b>Severity:</b> {{.incident.severity}}\&quot;,\&quot;enable\&quot;:true}}&quot;}}</para>
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Templates { get; set; }

        /// <summary>
        /// <para>The notification channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DING</description></item>
        /// <item><description>WEIXIN</description></item>
        /// <item><description>FEISHU</description></item>
        /// <item><description>SLACK</description></item>
        /// <item><description>CUSTOM</description></item>
        /// <item><description>TEAMS</description></item>
        /// <item><description>SMS</description></item>
        /// <item><description>EMAIL</description></item>
        /// <item><description>CALL</description></item>
        /// <item><description>PAGER_DUTY</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DING</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
