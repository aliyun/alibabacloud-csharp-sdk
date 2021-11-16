// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineModelsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachineModelsResponseBodyModels> Models { get; set; }
        public class DescribeEdgeMachineModelsResponseBodyModels : TeaModel {
            /// <summary>
            /// cpu
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// cpu arch
            /// </summary>
            [NameInMap("cpu_arch")]
            [Validation(Required=false)]
            public string CpuArch { get; set; }

            /// <summary>
            /// created
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// description
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// manage runtime
            /// </summary>
            [NameInMap("manage_runtime")]
            [Validation(Required=false)]
            public int? ManageRuntime { get; set; }

            /// <summary>
            /// memory
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// model
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// model id
            /// </summary>
            [NameInMap("model_id")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

        }

    }

}
