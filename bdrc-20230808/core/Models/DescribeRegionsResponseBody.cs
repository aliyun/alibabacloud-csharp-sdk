// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response parameters</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyData Data { get; set; }
        public class DescribeRegionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Regions</para>
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyDataRegions> Regions { get; set; }
            public class DescribeRegionsResponseBodyDataRegions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

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

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE43C4CB-8074-5EBD-9806-8CA6D12800B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
