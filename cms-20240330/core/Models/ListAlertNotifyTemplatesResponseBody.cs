// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertNotifyTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of notification templates.</para>
        /// </summary>
        [NameInMap("alertNotifyTemplates")]
        [Validation(Required=false)]
        public List<ListAlertNotifyTemplatesResponseBodyAlertNotifyTemplates> AlertNotifyTemplates { get; set; }
        public class ListAlertNotifyTemplatesResponseBodyAlertNotifyTemplates : TeaModel {
            /// <summary>
            /// <para>The notification template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template-abc123</para>
            /// </summary>
            [NameInMap("alertNotifyTemplateId")]
            [Validation(Required=false)]
            public string AlertNotifyTemplateId { get; set; }

            /// <summary>
            /// <para>The notification template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>High-availability alert template</para>
            /// </summary>
            [NameInMap("alertNotifyTemplateName")]
            [Validation(Required=false)]
            public string AlertNotifyTemplateName { get; set; }

            /// <summary>
            /// <para>The template syntax type. The current template syntax is fixed to GO and uses the Go template syntax.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GO</para>
            /// </summary>
            [NameInMap("programLang")]
            [Validation(Required=false)]
            public string ProgramLang { get; set; }

            /// <summary>
            /// <para>The multilingual notification templates. The key is the language code: zh (Chinese) or en (English). The value is the template configuration object for the language. When a notification is sent, the corresponding template is selected based on the recipient\&quot;s language. The content format varies by type: Markdown for DING, WEIXIN, and FEISHU; HTML for EMAIL; plain text for SMS, CALL, and SLACK; and JSON for CUSTOM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;zh&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}\n<b>Events:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:{&quot;IncidentCreationNotify&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true},&quot;IncidentResolutionNotify&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert Resolved: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true}}},&quot;en&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}\n<b>Events:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:{&quot;IncidentCreationNotify&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true},&quot;IncidentResolutionNotify&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert Resolved: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true}}}}</para>
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

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-**********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
