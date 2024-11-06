// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserResourcePackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96ED3127-EC7A-57C5-AFA6-A689B24B2530</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information about resource plans. The returned information is displayed in the format that is specified by the ResourcePackageInfo parameter.</para>
        /// </summary>
        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfos ResourcePackageInfos { get; set; }
        public class DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            [NameInMap("ResourcePackageInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo> ResourcePackageInfo { get; set; }
            public class DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo : TeaModel {
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
                /// <para>The remaining quota of the resource plan.</para>
                /// <list type="bullet">
                /// <item><description>The unit for traffic: bytes.</description></item>
                /// <item><description>The unit for requests: count.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10000000</para>
                /// </summary>
                [NameInMap("CurrCapacity")]
                [Validation(Required=false)]
                public string CurrCapacity { get; set; }

                /// <summary>
                /// <para>The name of the resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTPS requests for static content</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The expiration time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-24T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The total quota of the resource plan.</para>
                /// <list type="bullet">
                /// <item><description>The unit for traffic: bytes.</description></item>
                /// <item><description>The unit for requests: count.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10000000</para>
                /// </summary>
                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public string InitCapacity { get; set; }

                /// <summary>
                /// <para>The ID of the resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDNFLOWBAG-cn-7pp2bihrb01ii0</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The validation time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-24T04:09:22Z</para>
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
                /// <para>FPT_dcdnpaybag_deadlineAcc_1541151058</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

    }

}
