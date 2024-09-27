// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud-native box models.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachineModelsResponseBodyModels> Models { get; set; }
        public class DescribeEdgeMachineModelsResponseBodyModels : TeaModel {
            /// <summary>
            /// <para>The number of vCores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The CPU architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86_64/arm64</para>
            /// </summary>
            [NameInMap("cpu_arch")]
            [Validation(Required=false)]
            public string CpuArch { get; set; }

            /// <summary>
            /// <para>The time when the cloud-native box was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-07T20:44:00+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The description of the cloud-native box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B010</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud-native box model manages the Docker runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0/1</para>
            /// </summary>
            [NameInMap("manage_runtime")]
            [Validation(Required=false)]
            public int? ManageRuntime { get; set; }

            /// <summary>
            /// <para>The memory. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The model of the cloud-native box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACK-V-B010</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The ID of the cloud-native box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c34cc753-8908-4739-bd10-ebd922a4****</para>
            /// </summary>
            [NameInMap("model_id")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

        }

    }

}
