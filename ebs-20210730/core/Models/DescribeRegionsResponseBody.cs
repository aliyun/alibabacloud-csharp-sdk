// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of region and zone information.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The endpoint of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ebs.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("RegionEndpoint")]
            [Validation(Required=false)]
            public string RegionEndpoint { get; set; }

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
            /// <para>The collection of zone information.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsZones> Zones { get; set; }
            public class DescribeRegionsResponseBodyRegionsZones : TeaModel {
                /// <summary>
                /// <para>The zone name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou Zone H</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The list of resource types.</para>
                /// </summary>
                [NameInMap("ResourceTypes")]
                [Validation(Required=false)]
                public List<string> ResourceTypes { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17EE62D8-064E-5404-8B0D-72122478****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
