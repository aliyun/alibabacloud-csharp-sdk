// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeStoragePlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of storage plans.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeStoragePlanResponseBodyItems> Items { get; set; }
        public class DescribeStoragePlanResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18170112322*****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_package</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The expiration time of the storage plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-23 00:00:00</para>
            /// </summary>
            [NameInMap("EndTimes")]
            [Validation(Required=false)]
            public string EndTimes { get; set; }

            /// <summary>
            /// <para>The capacity unit of the storage plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("InitCapaCityViewUnit")]
            [Validation(Required=false)]
            public string InitCapaCityViewUnit { get; set; }

            /// <summary>
            /// <para>The total capacity of the storage plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500.000</para>
            /// </summary>
            [NameInMap("InitCapacityViewValue")]
            [Validation(Required=false)]
            public string InitCapacityViewValue { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500072****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The periodic capacity unit of the storage plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("PeriodCapaCityViewUnit")]
            [Validation(Required=false)]
            public string PeriodCapaCityViewUnit { get; set; }

            /// <summary>
            /// <para>The periodic capacity of the storage plan. The periodic capacity gradually decreases as the storage plan is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400.000</para>
            /// </summary>
            [NameInMap("PeriodCapacityViewValue")]
            [Validation(Required=false)]
            public string PeriodCapacityViewValue { get; set; }

            /// <summary>
            /// <para>The period duration, which indicates that the capacity of the storage plan is measured and consumed on an hourly basis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("PeriodTime")]
            [Validation(Required=false)]
            public string PeriodTime { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb</para>
            /// </summary>
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            /// <summary>
            /// <para>The purchase time of the storage plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-22 12:03:27</para>
            /// </summary>
            [NameInMap("PurchaseTimes")]
            [Validation(Required=false)]
            public string PurchaseTimes { get; set; }

            /// <summary>
            /// <para>The effective period of the storage plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-22 12:03:25</para>
            /// </summary>
            [NameInMap("StartTimes")]
            [Validation(Required=false)]
            public string StartTimes { get; set; }

            /// <summary>
            /// <para>The status of the storage plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Valid</b>: The storage plan is valid.</para>
            /// </description></item>
            /// <item><description><para><b>Invalid</b>: The storage plan is invalid.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Valid</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the storage plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Overseas</b>: Hong Kong (China) and regions outside the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>Mainland</b>: The Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>Financial</b>: Alibaba Finance Cloud.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Overseas</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The type of the resource plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>FPT_polardb_package_absolute_1540888383</b>: The Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>FPT_polardb_package_absolute_1540890081</b>: Hong Kong (China) and regions outside the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>FPT_polardb_package_absolute_1567151499</b>: Alibaba Finance Cloud.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FPT_polardb_package_absolute_1540890081</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9384D30-5C9A-11EA-BFC0-F754D2Bxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
