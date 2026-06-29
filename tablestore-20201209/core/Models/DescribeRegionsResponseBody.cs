// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The region key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yunjiankong.cloud.region.cn-hangzhou</para>
            /// </summary>
            [NameInMap("I18nKey")]
            [Validation(Required=false)]
            public string I18nKey { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39871ED2-62C0-578F-A32E-B88072D5582F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
