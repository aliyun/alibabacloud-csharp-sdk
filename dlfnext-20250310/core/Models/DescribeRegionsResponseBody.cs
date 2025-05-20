// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The region description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The region name</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region show name</para>
            /// </summary>
            [NameInMap("showName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The region type</para>
            /// 
            /// <b>Example:</b>
            /// <para>region</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
