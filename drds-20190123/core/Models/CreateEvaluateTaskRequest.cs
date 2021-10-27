// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateEvaluateTaskRequest : TeaModel {
        [NameInMap("AvgQpsGrowthScale")]
        [Validation(Required=false)]
        public int? AvgQpsGrowthScale { get; set; }

        [NameInMap("DataGrowthScale")]
        [Validation(Required=false)]
        public int? DataGrowthScale { get; set; }

        [NameInMap("DbInfo")]
        [Validation(Required=false)]
        public List<CreateEvaluateTaskRequestDbInfo> DbInfo { get; set; }
        public class CreateEvaluateTaskRequestDbInfo : TeaModel {
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("DbPassword")]
            [Validation(Required=false)]
            public string DbPassword { get; set; }

            [NameInMap("DbPort")]
            [Validation(Required=false)]
            public string DbPort { get; set; }

            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            [NameInMap("InstId")]
            [Validation(Required=false)]
            public string InstId { get; set; }

        }

        [NameInMap("EvaluateHours")]
        [Validation(Required=false)]
        public int? EvaluateHours { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
