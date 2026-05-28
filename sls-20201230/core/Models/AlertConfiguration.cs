// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AlertConfiguration : TeaModel {
        /// <summary>
        /// <para>The annotations of the alert rule.</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<AlertTag> Annotations { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the system to automatically add annotations to the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoAnnotation")]
        [Validation(Required=false)]
        public bool? AutoAnnotation { get; set; }

        /// <summary>
        /// <para>The alert trigger conditions.</para>
        /// </summary>
        [NameInMap("conditionConfiguration")]
        [Validation(Required=false)]
        public ConditionConfiguration ConditionConfiguration { get; set; }

        /// <summary>
        /// <para>The ID of the dashboard associated with the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dasnboardExample</para>
        /// </summary>
        [NameInMap("dashboard")]
        [Validation(Required=false)]
        public string Dashboard { get; set; }

        /// <summary>
        /// <para>The configurations of group evaluation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupConfiguration")]
        [Validation(Required=false)]
        public GroupConfiguration GroupConfiguration { get; set; }

        /// <summary>
        /// <para>The set operation configurations for the query statements of the alert rule.</para>
        /// </summary>
        [NameInMap("joinConfigurations")]
        [Validation(Required=false)]
        public List<JoinConfiguration> JoinConfigurations { get; set; }

        /// <summary>
        /// <para>The labels of the alert rule.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<AlertTag> Labels { get; set; }

        /// <summary>
        /// <para>The time when a paused alert rule is resumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698907508</para>
        /// </summary>
        [NameInMap("muteUntil")]
        [Validation(Required=false)]
        public long? MuteUntil { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the no-data alert feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("noDataFire")]
        [Validation(Required=false)]
        public bool? NoDataFire { get; set; }

        /// <summary>
        /// <para>The severity of the no-data alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("noDataSeverity")]
        [Validation(Required=false)]
        public int? NoDataSeverity { get; set; }

        /// <summary>
        /// <para>The notification configurations of Simple Log Service.</para>
        /// </summary>
        [NameInMap("policyConfiguration")]
        [Validation(Required=false)]
        public PolicyConfiguration PolicyConfiguration { get; set; }

        /// <summary>
        /// <para>The query statements.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("queryList")]
        [Validation(Required=false)]
        public List<AlertQuery> QueryList { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a recovery notification after an alert is cleared.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sendResolved")]
        [Validation(Required=false)]
        public bool? SendResolved { get; set; }

        /// <summary>
        /// <para>The alert severity configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("severityConfigurations")]
        [Validation(Required=false)]
        public List<SeverityConfiguration> SeverityConfigurations { get; set; }

        /// <summary>
        /// <para>The configurations that allow alerts to be sent to the notification system of Simple Log Service.</para>
        /// </summary>
        [NameInMap("sinkAlerthub")]
        [Validation(Required=false)]
        public SinkAlerthubConfiguration SinkAlerthub { get; set; }

        /// <summary>
        /// <para>The configurations that allow alerts to be sent to CloudMonitor Event Center.</para>
        /// </summary>
        [NameInMap("sinkCms")]
        [Validation(Required=false)]
        public SinkCmsConfiguration SinkCms { get; set; }

        /// <summary>
        /// <para>The configurations that allow alerts to be sent to an Eventstore.</para>
        /// </summary>
        [NameInMap("sinkEventStore")]
        [Validation(Required=false)]
        public SinkEventStoreConfiguration SinkEventStore { get; set; }

        /// <summary>
        /// <para>The custom tags of the alert rule.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The alert template configurations.</para>
        /// </summary>
        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public TemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>The maximum number of consecutive times that the trigger condition is met.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

        /// <summary>
        /// <para>The type of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
