// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class PrecheckMyCatEvaluateRequest : TeaModel {
        [NameInMap("BusPeakQps")]
        [Validation(Required=false)]
        public long? BusPeakQps { get; set; }

        [NameInMap("CapacityIncPercent")]
        [Validation(Required=false)]
        public int? CapacityIncPercent { get; set; }

        [NameInMap("ImportDbList")]
        [Validation(Required=false)]
        public List<string> ImportDbList { get; set; }

        [NameInMap("QpsIncPercent")]
        [Validation(Required=false)]
        public int? QpsIncPercent { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RuleUrl")]
        [Validation(Required=false)]
        public string RuleUrl { get; set; }

        [NameInMap("SchemaUrl")]
        [Validation(Required=false)]
        public string SchemaUrl { get; set; }

        [NameInMap("SequenceType")]
        [Validation(Required=false)]
        public int? SequenceType { get; set; }

        [NameInMap("ServerUrl")]
        [Validation(Required=false)]
        public string ServerUrl { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
