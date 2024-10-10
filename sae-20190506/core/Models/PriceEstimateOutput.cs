// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class PriceEstimateOutput : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<PriceEstimateOutputApps> Apps { get; set; }
        public class PriceEstimateOutputApps : TeaModel {
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public PriceEstimateFeature Feature { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Usages")]
            [Validation(Required=false)]
            public List<PriceEstimateOutputAppsUsages> Usages { get; set; }
            public class PriceEstimateOutputAppsUsages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3600.00</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Microservice_cpuUsage</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>核*秒</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<PriceEstimateOutputItems> Items { get; set; }
        public class PriceEstimateOutputItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3600.00</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public float? Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p_micro_service_cpu</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.00</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            [NameInMap("Steps")]
            [Validation(Required=false)]
            public List<PriceEstimateOutputItemsSteps> Steps { get; set; }
            public class PriceEstimateOutputItemsSteps : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public long? Begin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0001</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public float? Price { get; set; }

                [NameInMap("RegionIds")]
                [Validation(Required=false)]
                public List<string> RegionIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>核*秒</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pack/post</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>核*秒</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>235.66</para>
        /// </summary>
        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public float? TotalPrice { get; set; }

    }

}
