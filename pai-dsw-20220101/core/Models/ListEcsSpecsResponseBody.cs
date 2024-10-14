// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListEcsSpecsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<ListEcsSpecsResponseBodyEcsSpecs> EcsSpecs { get; set; }
        public class ListEcsSpecsResponseBodyEcsSpecs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("AcceleratorType")]
            [Validation(Required=false)]
            public string AcceleratorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public long? CPU { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public long? GPU { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v100</para>
            /// </summary>
            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5120000</para>
            /// </summary>
            [NameInMap("InstanceBandwidthRx")]
            [Validation(Required=false)]
            public long? InstanceBandwidthRx { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.gn5-c28g1.7xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;foo\&quot;: \&quot;bar\&quot;}</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListEcsSpecsResponseBodyEcsSpecsLabels> Labels { get; set; }
            public class ListEcsSpecsResponseBodyEcsSpecsLabels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>stsTokenOwner</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22.8</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("SystemDiskCapacity")]
            [Validation(Required=false)]
            public long? SystemDiskCapacity { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;XXX&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
