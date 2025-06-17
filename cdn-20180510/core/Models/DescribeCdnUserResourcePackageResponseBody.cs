// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserResourcePackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84839536-2B7E-457D-9D8C-82E6C7D4E1A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information about resource plans. The returned information is displayed in an array of ResourcePackageInfo nodes.</para>
        /// </summary>
        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public DescribeCdnUserResourcePackageResponseBodyResourcePackageInfos ResourcePackageInfos { get; set; }
        public class DescribeCdnUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            [NameInMap("ResourcePackageInfo")]
            [Validation(Required=false)]
            public List<DescribeCdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo> ResourcePackageInfo { get; set; }
            public class DescribeCdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cdnflowbag</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The remaining quota of the resource plan.</para>
                /// <list type="bullet">
                /// <item><description>For a data transfer plan, the quota is measured in bytes.</description></item>
                /// <item><description>For a request resource plan, the quota is measured in the number of requests.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10995089554629</para>
                /// </summary>
                [NameInMap("CurrCapacity")]
                [Validation(Required=false)]
                public string CurrCapacity { get; set; }

                [NameInMap("CurrCapacityBaseUnit")]
                [Validation(Required=false)]
                public string CurrCapacityBaseUnit { get; set; }

                [NameInMap("CurrCapacityShowUnit")]
                [Validation(Required=false)]
                public string CurrCapacityShowUnit { get; set; }

                [NameInMap("CurrCapacityShowValue")]
                [Validation(Required=false)]
                public string CurrCapacityShowValue { get; set; }

                /// <summary>
                /// <para>The name of the resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDN data transfer plan (Chinese mainland)</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-01T08:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The total quota of the resource plan.</para>
                /// <list type="bullet">
                /// <item><description>For a data transfer plan, the quota is measured in bytes.</description></item>
                /// <item><description>For a request resource plan, the quota is measured in the number of requests.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>536870912000</para>
                /// </summary>
                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public string InitCapacity { get; set; }

                [NameInMap("InitCapacityBaseUnit")]
                [Validation(Required=false)]
                public string InitCapacityBaseUnit { get; set; }

                [NameInMap("InitCapacityShowUnit")]
                [Validation(Required=false)]
                public string InitCapacityShowUnit { get; set; }

                [NameInMap("InitCapacityShowValue")]
                [Validation(Required=false)]
                public string InitCapacityShowValue { get; set; }

                /// <summary>
                /// <para>The ID of the instance</para>
                /// 
                /// <b>Example:</b>
                /// <para>FP-ilttxc23a</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The effective time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-05T19:10:58Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the resource plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>valid</b>: valid</description></item>
                /// <item><description><b>closed</b>: expired</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>valid</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDN data transfer plan</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

    }

}
