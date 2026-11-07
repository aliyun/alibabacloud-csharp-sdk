// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of session instance types on the current page.</para>
        /// </summary>
        [NameInMap("AppInstanceTypeModels")]
        [Validation(Required=false)]
        public List<ListAppInstanceTypeResponseBodyAppInstanceTypeModels> AppInstanceTypeModels { get; set; }
        public class ListAppInstanceTypeResponseBodyAppInstanceTypeModels : TeaModel {
            /// <summary>
            /// <para>The session instance type code, which can be used as the session instance type parameter for subsequent operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu.4c8g</para>
            /// </summary>
            [NameInMap("AppInstanceType")]
            [Validation(Required=false)]
            public string AppInstanceType { get; set; }

            /// <summary>
            /// <para>The instance type family code to which the session instance type belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6</para>
            /// </summary>
            [NameInMap("AppInstanceTypeFamily")]
            [Validation(Required=false)]
            public string AppInstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The number of CPU cores included in the instance type, represented by a numeric string. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The data cloud disk capacity of the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public long? DataDiskSize { get; set; }

            /// <summary>
            /// <para>Not enabled yet. The example value is only used to demonstrate the format and does not represent the actual number of GPUs returned by this operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public string Gpu { get; set; }

            /// <summary>
            /// <para>The GPU memory capacity of the instance type. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            /// <summary>
            /// <para>The display value or display range of the GPU memory. Display it as the returned text. Do not directly use it as a numeric value for capacity conversion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1~2</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The identifier of the instance type record. When integrating with pricing or creation operations, use <c>AppInstanceType</c>. Do not use this field to replace the instance type code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The display name of the instance type. The Chinese name is used only when <c>Language</c> is set to <c>zh-CN</c>. For other values or when omitted, the instance type code is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu.4c8g</para>
            /// </summary>
            [NameInMap("InstanceTypeName")]
            [Validation(Required=false)]
            public string InstanceTypeName { get; set; }

            /// <summary>
            /// <para>The inventory information of the instance type. This parameter is returned only when the inventory is queried and the relevant information is obtained. If this parameter is not returned, it does not mean that the inventory is 0.</para>
            /// </summary>
            [NameInMap("InventoryInfo")]
            [Validation(Required=false)]
            public ListAppInstanceTypeResponseBodyAppInstanceTypeModelsInventoryInfo InventoryInfo { get; set; }
            public class ListAppInstanceTypeResponseBodyAppInstanceTypeModelsInventoryInfo : TeaModel {
                /// <summary>
                /// <para>The business region ID corresponding to the inventory query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The instance type inventory status obtained in the current query.</para>
                /// <list type="bullet">
                /// <item><description><c>Available</c>: The total inventory of the queried zones is greater than 0.</description></item>
                /// <item><description><c>SoldOut</c>: The total inventory of the queried zones is not greater than 0.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The list of inventory information returned by zone.</para>
                /// </summary>
                [NameInMap("ZoneInventoryInfo")]
                [Validation(Required=false)]
                public List<ListAppInstanceTypeResponseBodyAppInstanceTypeModelsInventoryInfoZoneInventoryInfo> ZoneInventoryInfo { get; set; }
                public class ListAppInstanceTypeResponseBodyAppInstanceTypeModelsInventoryInfoZoneInventoryInfo : TeaModel {
                    /// <summary>
                    /// <para>The available quantity in the zone obtained in this query. Unit: instances. This value is an inventory snapshot and does not indicate that resources have been reserved for the current account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The zone ID, which can be queried by calling the <a href="https://api.aliyun.com/document/appstream-center/2021-09-01/ListZones">ListZones</a> operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            /// <summary>
            /// <para>The memory capacity of the instance type. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The type of the product to which the instance type belongs. The current document displays the following values:</para>
            /// <list type="bullet">
            /// <item><description><c>CloudApp</c>: Wuying Cloud Application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The system cloud disk capacity of the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The page number used in this query, which corresponds to the request parameters and the total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page used in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instance types that meet all filtering conditions, not the number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
