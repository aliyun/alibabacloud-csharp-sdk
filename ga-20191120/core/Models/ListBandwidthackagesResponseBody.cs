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
            /// <para>The IDs of the GA instances that are associated with the bandwidth plans.</para>
            /// </summary>
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<string> Accelerators { get; set; }

            /// <summary>
            /// <para>The bandwidth of the bandwidth plan. Unit: Mbit/s.</para>
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
            /// <para>The billing method of the bandwidth plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b>: subscription. This is the default value.</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the bandwidth plan was created.</para>
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
            /// <para>The expiration time of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578966918000</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The name of the GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accelerator</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
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
            /// <para>The status of the bandwidth plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init:</b> The bandwidth plan is being initialized.</description></item>
            /// <item><description><b>active:</b> The bandwidth plan is available.</description></item>
            /// <item><description><b>binded:</b> The bandwidth plan is associated with a GA instance.</description></item>
            /// <item><description><b>binding:</b> The bandwidth plan is being associated with a GA instance.</description></item>
            /// <item><description><b>unbinding:</b> The bandwidth plan is being disassociated from a GA instance.</description></item>
            /// <item><description><b>updating:</b> The bandwidth plan is being updated.</description></item>
            /// <item><description><b>finacialLocked:</b> The bandwidth plan is locked due to overdue payments.</description></item>
            /// <item><description><b>locked:</b> The bandwidth plan is locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The tag of the bandwidth plan.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListBandwidthackagesResponseBodyBandwidthPackagesTags> Tags { get; set; }
            public class ListBandwidthackagesResponseBodyBandwidthPackagesTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the bandwidth plan.</para>
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
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
