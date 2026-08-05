// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeUserResourcePackageResponseBody : TeaModel {
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of ResourcePackageInfo objects.</para>
        /// </summary>
        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public List<DescribeUserResourcePackageResponseBodyResourcePackageInfos> ResourcePackageInfos { get; set; }
        public class DescribeUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            /// <summary>
            /// <para>The commodity code of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcdnpaybag</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The current remaining capacity of the instance.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit for data transfer plans: Byte.</para>
            /// </description></item>
            /// <item><description><para>Unit for request count plans: count.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>53661095687</para>
            /// </summary>
            [NameInMap("CurrCapacity")]
            [Validation(Required=false)]
            public string CurrCapacity { get; set; }

            /// <summary>
            /// <para>The base unit of the current remaining capacity of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Byte</para>
            /// </summary>
            [NameInMap("CurrCapacityBaseUnit")]
            [Validation(Required=false)]
            public string CurrCapacityBaseUnit { get; set; }

            /// <summary>
            /// <para>The display unit of the current remaining capacity of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("CurrCapacityShowUnit")]
            [Validation(Required=false)]
            public string CurrCapacityShowUnit { get; set; }

            /// <summary>
            /// <para>The display value of the current remaining capacity of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49.975789</para>
            /// </summary>
            [NameInMap("CurrCapacityShowValue")]
            [Validation(Required=false)]
            public string CurrCapacityShowValue { get; set; }

            /// <summary>
            /// <para>The name of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Transfer Plan in Asia Pacific 1</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The expiration time in UTC. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-02T15:59:59Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The total capacity of the resource plan.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit for data transfer plans: Byte.</para>
            /// </description></item>
            /// <item><description><para>Unit for request count plans: count.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>107374182400</para>
            /// </summary>
            [NameInMap("InitCapacity")]
            [Validation(Required=false)]
            public string InitCapacity { get; set; }

            /// <summary>
            /// <para>The base unit of the total capacity of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Byte</para>
            /// </summary>
            [NameInMap("InitCapacityBaseUnit")]
            [Validation(Required=false)]
            public string InitCapacityBaseUnit { get; set; }

            /// <summary>
            /// <para>The display unit of the total capacity of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("InitCapacityShowUnit")]
            [Validation(Required=false)]
            public string InitCapacityShowUnit { get; set; }

            /// <summary>
            /// <para>The display value of the total capacity of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.000000</para>
            /// </summary>
            [NameInMap("InitCapacityShowValue")]
            [Validation(Required=false)]
            public string InitCapacityShowValue { get; set; }

            /// <summary>
            /// <para>The instance ID of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>_ResourcePack-cn-</b></b></para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The effective period in UTC. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-20T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FPT_dcdnpaybag_deadlineAcc_****</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
