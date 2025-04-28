// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeRegionsMixedResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsMixedResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsMixedResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsMixedResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeRegionsMixedResponseBodyRegionsRegion : TeaModel {
                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The version of the cluster.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>2.0</description></item>
                /// <item><description>3.0</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E9450FF-F8AD-54C6-B3C3-009FBD7C0700</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
