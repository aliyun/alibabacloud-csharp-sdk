// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaCensorJobRequest : TeaModel {
        [NameInMap("Barrages")]
        [Validation(Required=false)]
        public string Barrages { get; set; }

        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImages { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestInput Input { get; set; }
        public class SubmitMediaCensorJobRequestInput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitMediaCensorJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
        };

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
