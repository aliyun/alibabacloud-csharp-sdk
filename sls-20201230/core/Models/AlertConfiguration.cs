// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AlertConfiguration : TeaModel {
        /// <summary>
        /// <para>The alert annotations.</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<AlertTag> Annotations { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic annotation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoAnnotation")]
        [Validation(Required=false)]
        public bool? AutoAnnotation { get; set; }

        /// <summary>
        /// <para>The alert trigger condition.</para>
        /// </summary>
        [NameInMap("conditionConfiguration")]
        [Validation(Required=false)]
        public ConditionConfiguration ConditionConfiguration { get; set; }

        /// <summary>
        /// <para>The ID of the dashboard to which the alert is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DasnboardExample</para>
        /// </summary>
        [NameInMap("dashboard")]
        [Validation(Required=false)]
        public string Dashboard { get; set; }

        /// <summary>
        /// <para>The group evaluation configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupConfiguration")]
        [Validation(Required=false)]
        public GroupConfiguration GroupConfiguration { get; set; }

        /// <summary>
        /// <para>The configurations for joining the results of query statements.</para>
        /// </summary>
        [NameInMap("joinConfigurations")]
        [Validation(Required=false)]
        public List<JoinConfiguration> JoinConfigurations { get; set; }

        /// <summary>
        /// <para>The alert labels.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<AlertTag> Labels { get; set; }

        /// <summary>
        /// <para>The time until which the alert is muted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698907508</para>
        /// </summary>
        [NameInMap("muteUntil")]
        [Validation(Required=false)]
        public long? MuteUntil { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable no-data alerts.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("noDataFire")]
        [Validation(Required=false)]
        public bool? NoDataFire { get; set; }

        /// <summary>
        /// <para>The severity of no-data alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("noDataSeverity")]
        [Validation(Required=false)]
        public int? NoDataSeverity { get; set; }

        /// <summary>
        /// <para>The configuration for the SLS alert notification service.</para>
        /// </summary>
        [NameInMap("policyConfiguration")]
        [Validation(Required=false)]
        public PolicyConfiguration PolicyConfiguration { get; set; }

        /// <summary>
        /// <para>The list of query statements.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("queryList")]
        [Validation(Required=false)]
        public List<AlertQuery> QueryList { get; set; }

        /// <summary>
        /// <para>Specifies whether to send recovery alerts.</para>
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
        /// <para>The configuration for sending alerts to the SLS alert management service.</para>
        /// </summary>
        [NameInMap("sinkAlerthub")]
        [Validation(Required=false)]
        public SinkAlerthubConfiguration SinkAlerthub { get; set; }

        /// <summary>
        /// <para>The configuration for sending alerts to Cloud Monitor.</para>
        /// </summary>
        [NameInMap("sinkCms")]
        [Validation(Required=false)]
        public SinkCmsConfiguration SinkCms { get; set; }

        /// <summary>
        /// <para>The configuration for sending alerts to the eventstore.</para>
        /// </summary>
        [NameInMap("sinkEventStore")]
        [Validation(Required=false)]
        public SinkEventStoreConfiguration SinkEventStore { get; set; }

        /// <summary>
        /// <para>The custom alert tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The alert template configuration.</para>
        /// </summary>
        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public TemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>The consecutive trigger threshold.</para>
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
