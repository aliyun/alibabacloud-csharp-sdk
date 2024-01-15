/**
 *
 */
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

        [NameInMap("autoAnnotation")]
        [Validation(Required=false)]
        public bool? AutoAnnotation { get; set; }

        [NameInMap("conditionConfiguration")]
        [Validation(Required=false)]
        public ConditionConfiguration ConditionConfiguration { get; set; }

        [NameInMap("dashboard")]
        [Validation(Required=false)]
        public string Dashboard { get; set; }

        [NameInMap("groupConfiguration")]
        [Validation(Required=false)]
        public GroupConfiguration GroupConfiguration { get; set; }

        [NameInMap("joinConfigurations")]
        [Validation(Required=false)]
        public List<JoinConfiguration> JoinConfigurations { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<AlertTag> Labels { get; set; }

        [NameInMap("muteUntil")]
        [Validation(Required=false)]
        public long? MuteUntil { get; set; }

        [NameInMap("noDataFire")]
        [Validation(Required=false)]
        public bool? NoDataFire { get; set; }

        [NameInMap("noDataSeverity")]
        [Validation(Required=false)]
        public int? NoDataSeverity { get; set; }

        [NameInMap("policyConfiguration")]
        [Validation(Required=false)]
        public PolicyConfiguration PolicyConfiguration { get; set; }

        [NameInMap("queryList")]
        [Validation(Required=false)]
        public List<AlertQuery> QueryList { get; set; }

        [NameInMap("sendResolved")]
        [Validation(Required=false)]
        public bool? SendResolved { get; set; }

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

        [NameInMap("threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
