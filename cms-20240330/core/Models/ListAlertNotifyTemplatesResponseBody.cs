// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertNotifyTemplatesResponseBody : TeaModel {
        [NameInMap("alertNotifyTemplates")]
        [Validation(Required=false)]
        public List<ListAlertNotifyTemplatesResponseBodyAlertNotifyTemplates> AlertNotifyTemplates { get; set; }
        public class ListAlertNotifyTemplatesResponseBodyAlertNotifyTemplates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>template-abc123</para>
            /// </summary>
            [NameInMap("alertNotifyTemplateId")]
            [Validation(Required=false)]
            public string AlertNotifyTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>高可用性告警模板</para>
            /// </summary>
            [NameInMap("alertNotifyTemplateName")]
            [Validation(Required=false)]
            public string AlertNotifyTemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GO</para>
            /// </summary>
            [NameInMap("programLang")]
            [Validation(Required=false)]
            public string ProgramLang { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;zh&quot;:{&quot;title&quot;:&quot;云监控报警: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>报警标题:</b> {{.incident.title}}\n<b>级别:</b> {{.incident.severity}}\n<b>事件数:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:{&quot;IncidentCreationNotify&quot;:{&quot;title&quot;:&quot;云监控报警: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>报警标题:</b> {{.incident.title}}\n<b>级别:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true},&quot;IncidentResolutionNotify&quot;:{&quot;title&quot;:&quot;云监控报警已解决: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>报警标题:</b> {{.incident.title}}\n<b>级别:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true}}},&quot;en&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}\n<b>Events:</b> {{len .events}}&quot;,&quot;incidentLifeCycleNotifyTemplates&quot;:{&quot;IncidentCreationNotify&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true},&quot;IncidentResolutionNotify&quot;:{&quot;title&quot;:&quot;CloudMonitor Alert Resolved: {{.incident.title}}&quot;,&quot;content&quot;:&quot;<b>Alert Title:</b> {{.incident.title}}\n<b>Severity:</b> {{.incident.severity}}&quot;,&quot;enable&quot;:true}}}}</para>
            /// </summary>
            [NameInMap("templates")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Templates { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DING</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-**********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
