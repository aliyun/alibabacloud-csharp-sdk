// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ResourceSpec : TeaModel {
        /// <summary>
        /// <para>The number of CUs. Currently, 1 CU is equivalent to 1 vCPU and 4 GB of memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The number of GPU machines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("gpuMachineNum")]
        [Validation(Required=false)]
        public int? GpuMachineNum { get; set; }

        /// <summary>
        /// <para>The instance type ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.gn7i-c32g1.8xlarge</para>
        /// </summary>
        [NameInMap("instanceTypeId")]
        [Validation(Required=false)]
        public string InstanceTypeId { get; set; }

        /// <summary>
        /// <para>The upper limit of the absolute value for the queue quota. If not specified, the backend falls back to the number of CUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("maxCu")]
        [Validation(Required=false)]
        public int? MaxCu { get; set; }

    }

}
