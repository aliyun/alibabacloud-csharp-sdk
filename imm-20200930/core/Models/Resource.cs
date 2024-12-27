// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Resource : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public long? CPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.gn5i-c2g1.large</para>
        /// </summary>
        [NameInMap("ECSInstance")]
        [Validation(Required=false)]
        public string ECSInstance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>string	NVIDIA_P4</para>
        /// </summary>
        [NameInMap("GPUModel")]
        [Validation(Required=false)]
        public string GPUModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GPUNum")]
        [Validation(Required=false)]
        public long? GPUNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>string	ecs.gn5i-c2g1.large-2vCPU-8GB-1*NVIDIA_P4</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RAM")]
        [Validation(Required=false)]
        public long? RAM { get; set; }

    }

}
