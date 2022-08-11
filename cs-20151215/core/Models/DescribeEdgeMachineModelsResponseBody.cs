// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineModelsResponseBody : TeaModel {
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachineModelsResponseBodyModels> Models { get; set; }
        public class DescribeEdgeMachineModelsResponseBodyModels : TeaModel {
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("cpu_arch")]
            [Validation(Required=false)]
            public string CpuArch { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("manage_runtime")]
            [Validation(Required=false)]
            public int? ManageRuntime { get; set; }

            [NameInMap("memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("model_id")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

        }

    }

}
