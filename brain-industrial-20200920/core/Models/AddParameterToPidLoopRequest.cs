// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class AddParameterToPidLoopRequest : TeaModel {
        [NameInMap("PidProjectId")]
        [Validation(Required=true)]
        public string PidProjectId { get; set; }

        [NameInMap("PidLoopId")]
        [Validation(Required=true)]
        public string PidLoopId { get; set; }

        [NameInMap("PidLoopParameterId")]
        [Validation(Required=true)]
        public string PidLoopParameterId { get; set; }

        [NameInMap("AdjustType")]
        [Validation(Required=true)]
        public int? AdjustType { get; set; }

        [NameInMap("ModelDistinguish")]
        [Validation(Required=false)]
        public Dictionary<string, object> ModelDistinguish { get; set; }

        [NameInMap("ParameterTuning")]
        [Validation(Required=false)]
        public Dictionary<string, object> ParameterTuning { get; set; }

    }

}
