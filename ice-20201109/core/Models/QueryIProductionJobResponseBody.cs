// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryIProductionJobResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyInput Input { get; set; }
        public class QueryIProductionJobResponseBodyInput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyOutput Output { get; set; }
        public class QueryIProductionJobResponseBodyOutput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("OutputFiles")]
        [Validation(Required=false)]
        public List<string> OutputFiles { get; set; }

        [NameInMap("OutputUrls")]
        [Validation(Required=false)]
        public List<string> OutputUrls { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyScheduleConfig ScheduleConfig { get; set; }
        public class QueryIProductionJobResponseBodyScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
