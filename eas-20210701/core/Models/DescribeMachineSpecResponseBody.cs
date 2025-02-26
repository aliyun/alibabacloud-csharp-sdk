// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeMachineSpecResponseBody : TeaModel {
        [NameInMap("InstanceMetas")]
        [Validation(Required=false)]
        public List<DescribeMachineSpecResponseBodyInstanceMetas> InstanceMetas { get; set; }
        public class DescribeMachineSpecResponseBodyInstanceMetas : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GU30</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public string GPU { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GPUAmount")]
            [Validation(Required=false)]
            public int? GPUAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("GPUMemory")]
            [Validation(Required=false)]
            public float? GPUMemory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ml.gu7i.c32m188.1-gu30</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>188</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("NonProtectSpotDiscount")]
            [Validation(Required=false)]
            public float? NonProtectSpotDiscount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.12</para>
            /// </summary>
            [NameInMap("SpotDiscount")]
            [Validation(Required=false)]
            public float? SpotDiscount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WithStock</para>
            /// </summary>
            [NameInMap("StockStatus")]
            [Validation(Required=false)]
            public string StockStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<DescribeMachineSpecResponseBodyTypes> Types { get; set; }
        public class DescribeMachineSpecResponseBodyTypes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public List<int?> Memory { get; set; }

        }

    }

}
