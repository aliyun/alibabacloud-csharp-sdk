// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescirbeWorkflowResponseBody : TeaModel {
        [NameInMap("create_time")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("finish_time")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("input_data_size")]
        [Validation(Required=false)]
        public string InputDataSize { get; set; }

        [NameInMap("job_name")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("job_namespace")]
        [Validation(Required=false)]
        public string JobNamespace { get; set; }

        [NameInMap("output_data_size")]
        [Validation(Required=false)]
        public string OutputDataSize { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("total_bases")]
        [Validation(Required=false)]
        public string TotalBases { get; set; }

        [NameInMap("total_reads")]
        [Validation(Required=false)]
        public string TotalReads { get; set; }

        [NameInMap("user_input_data")]
        [Validation(Required=false)]
        public string UserInputData { get; set; }

    }

}
