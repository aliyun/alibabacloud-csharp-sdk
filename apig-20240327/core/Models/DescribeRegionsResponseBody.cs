// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyData Data { get; set; }
        public class DescribeRegionsResponseBodyData : TeaModel {
            [NameInMap("regions")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyDataRegions> Regions { get; set; }
            public class DescribeRegionsResponseBodyDataRegions : TeaModel {
                [NameInMap("localName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("regions")]
        [Validation(Required=false)]
        [Obsolete]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeRegionsResponseBodyRegionsRegion : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>华东1（杭州）</para>
                /// </summary>
                [NameInMap("localName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E6BD6C79-32B1-5D7E-A89A-93C5A6B7xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
