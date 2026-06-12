// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of available regions and their details.</para>
        /// </summary>
        [NameInMap("regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The supported data redundancy types.</para>
            /// </summary>
            [NameInMap("dataRedundancyType")]
            [Validation(Required=false)]
            public List<string> DataRedundancyType { get; set; }

            /// <summary>
            /// <para>The accelerated endpoint of the region.</para>
            /// </summary>
            [NameInMap("internalEndpoint")]
            [Validation(Required=false)]
            public string InternalEndpoint { get; set; }

            /// <summary>
            /// <para>The public endpoint of the region.</para>
            /// </summary>
            [NameInMap("internetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// <para>The intranet endpoint of the region.</para>
            /// </summary>
            [NameInMap("intranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <para>The display name of the region.</para>
            /// </summary>
            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
