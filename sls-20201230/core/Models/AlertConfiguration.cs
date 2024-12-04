// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AlertConfiguration : TeaModel {
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<AlertTag> Annotations { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoAnnotation")]
        [Validation(Required=false)]
        public bool? AutoAnnotation { get; set; }

        [NameInMap("conditionConfiguration")]
        [Validation(Required=false)]
        public ConditionConfiguration ConditionConfiguration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dasnboardExample</para>
        /// </summary>
        [NameInMap("dashboard")]
        [Validation(Required=false)]
        public string Dashboard { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupConfiguration")]
        [Validation(Required=false)]
        public GroupConfiguration GroupConfiguration { get; set; }

        [NameInMap("joinConfigurations")]
        [Validation(Required=false)]
        public List<JoinConfiguration> JoinConfigurations { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<AlertTag> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1698907508</para>
        /// </summary>
        [NameInMap("muteUntil")]
        [Validation(Required=false)]
        public long? MuteUntil { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("noDataFire")]
        [Validation(Required=false)]
        public bool? NoDataFire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("noDataSeverity")]
        [Validation(Required=false)]
        public int? NoDataSeverity { get; set; }

        [NameInMap("policyConfiguration")]
        [Validation(Required=false)]
        public PolicyConfiguration PolicyConfiguration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("queryList")]
        [Validation(Required=false)]
        public List<AlertQuery> QueryList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sendResolved")]
        [Validation(Required=false)]
        public bool? SendResolved { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("severityConfigurations")]
        [Validation(Required=false)]
        public List<SeverityConfiguration> SeverityConfigurations { get; set; }

        [NameInMap("sinkAlerthub")]
        [Validation(Required=false)]
        public SinkAlerthubConfiguration SinkAlerthub { get; set; }

        [NameInMap("sinkCms")]
        [Validation(Required=false)]
        public SinkCmsConfiguration SinkCms { get; set; }

        [NameInMap("sinkEventStore")]
        [Validation(Required=false)]
        public SinkEventStoreConfiguration SinkEventStore { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public TemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
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
