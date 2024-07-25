// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSmarttagJobRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ContentAddr")]
        [Validation(Required=false)]
        public string ContentAddr { get; set; }

        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// input
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSmarttagJobRequestInput Input { get; set; }
        public class SubmitSmarttagJobRequestInput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// scheduleConfig
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSmarttagJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSmarttagJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

        }

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
