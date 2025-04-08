// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of regions.</para>
        /// </summary>
        [NameInMap("RegionModelList")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegionModelList> RegionModelList { get; set; }
        public class DescribeRegionsResponseBodyRegionModelList : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>An array of zones.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionModelListZones> Zones { get; set; }
            public class DescribeRegionsResponseBodyRegionModelListZones : TeaModel {
                /// <summary>
                /// <para>The zone description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the VPC is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The zone name.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The subdomain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-h-aliyun</para>
                /// </summary>
                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

                /// <summary>
                /// <para>Indicates whether the VPC is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("VpcEnabled")]
                [Validation(Required=false)]
                public bool? VpcEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the virtual private cloud (VPC) is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-h</para>
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
        /// <para>F8900A96-67F7-5274-A41B-7722E1ECF8C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
