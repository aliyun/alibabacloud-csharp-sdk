// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBandwidthackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the bandwidth plans.</para>
        /// </summary>
        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public List<ListBandwidthackagesResponseBodyBandwidthPackages> BandwidthPackages { get; set; }
        public class ListBandwidthackagesResponseBodyBandwidthPackages : TeaModel {
            /// <summary>
            /// <para>The IDs of the Global Accelerator instances that are associated with the bandwidth plan.</para>
            /// </summary>
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<string> Accelerators { get; set; }

            /// <summary>
            /// <para>The bandwidth of the bandwidth plan. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The ID of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gbwp-bp1sgzldyj6b4q7cx****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// <list type="bullet">
            /// <item><description><para><b>PREPAY</b> (default): subscription.</para>
            /// </description></item>
            /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the bandwidth plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578966918000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the bandwidth plan expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578966918000</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The name of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accelerator</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzzwgr7vz2liy</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the bandwidth plan.</para>
            /// <list type="bullet">
            /// <item><description><para><b>init</b>: The bandwidth plan is being initialized.</para>
            /// </description></item>
            /// <item><description><para><b>active</b>: The bandwidth plan is available.</para>
            /// </description></item>
            /// <item><description><para><b>binded</b>: The bandwidth plan is bound.</para>
            /// </description></item>
            /// <item><description><para><b>binding</b>: The bandwidth plan is being bound.</para>
            /// </description></item>
            /// <item><description><para><b>unbinding</b>: The bandwidth plan is being unbound.</para>
            /// </description></item>
            /// <item><description><para><b>updating</b>: The bandwidth plan is being updated.</para>
            /// </description></item>
            /// <item><description><para><b>finacialLocked</b>: The bandwidth plan is financially locked.</para>
            /// </description></item>
            /// <item><description><para><b>locked</b>: The bandwidth plan is locked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The tags of the resource.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListBandwidthackagesResponseBodyBandwidthPackagesTags> Tags { get; set; }
            public class ListBandwidthackagesResponseBodyBandwidthPackagesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B6DBBB0-2D01-4C6A-A384-4129266E6B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
