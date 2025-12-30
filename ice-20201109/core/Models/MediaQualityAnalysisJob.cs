// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaQualityAnalysisJob : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobInput Input { get; set; }
        public class MediaQualityAnalysisJobInput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobScheduleConfig ScheduleConfig { get; set; }
        public class MediaQualityAnalysisJobScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobTemplateConfig TemplateConfig { get; set; }
        public class MediaQualityAnalysisJobTemplateConfig : TeaModel {
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("VqaResult")]
        [Validation(Required=false)]
        public MediaQualityAnalysisJobVqaResult VqaResult { get; set; }

    }

}
