// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeChildInstanceRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeChildInstanceRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeChildInstanceRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeChildInstanceRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeChildInstanceRegionsResponseBodyRegionsRegion : TeaModel {
                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5CEED59-36AA-47CC-9D81-16F71C46BD80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
