// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineModelsResponseBody : TeaModel {
        /// <summary>
        /// The list of details about the models of cloud-native boxes.
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachineModelsResponseBodyModels> Models { get; set; }
        public class DescribeEdgeMachineModelsResponseBodyModels : TeaModel {
            /// <summary>
            /// The number of CPU cores.
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The CPU architecture.
            /// </summary>
            [NameInMap("cpu_arch")]
            [Validation(Required=false)]
            public string CpuArch { get; set; }

            /// <summary>
            /// The time when the cloud-native box was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the Docker runtime is managed.
            /// </summary>
            [NameInMap("manage_runtime")]
            [Validation(Required=false)]
            public int? ManageRuntime { get; set; }

            /// <summary>
            /// The memory size. Unit: GB.
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// The model of the cloud-native box.
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// The ID of the cloud-native box.
            /// </summary>
            [NameInMap("model_id")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

        }

    }

}
