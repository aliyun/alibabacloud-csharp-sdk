// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DescribeRegionsOutput : TeaModel {
        /// <summary>
        /// <para>The region information.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsOutputRegions Regions { get; set; }
        public class DescribeRegionsOutputRegions : TeaModel {
            /// <summary>
            /// <para>The collection of region information.</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsOutputRegionsRegion> Region { get; set; }
            public class DescribeRegionsOutputRegionsRegion : TeaModel {
                /// <summary>
                /// <para>The region name.</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

    }

}
