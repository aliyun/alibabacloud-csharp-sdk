// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCensResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the CEN instances.</para>
        /// </summary>
        [NameInMap("Cens")]
        [Validation(Required=false)]
        public List<DescribeCensResponseBodyCens> Cens { get; set; }
        public class DescribeCensResponseBodyCens : TeaModel {
            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-3gwy16dojz1m65****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The time when the CEN instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-16T08:46Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IPv6 level.</para>
            /// <remarks>
            /// <para> IPv6 is not supported.</para>
            /// </remarks>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description><para>DISABLED</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DISABLED</para>
            /// </summary>
            [NameInMap("Ipv6Level")]
            [Validation(Required=false)]
            public string Ipv6Level { get; set; }

            /// <summary>
            /// <para>The name of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCen</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The bandwidth plans that are bound to the CEN instance.</para>
            /// </summary>
            [NameInMap("PackageIds")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensPackageIds> PackageIds { get; set; }
            public class DescribeCensResponseBodyCensPackageIds : TeaModel {
                /// <summary>
                /// <para>The ID of the bandwidth plan that is bound to the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cenbwp-4c2zaavbvh5f42****</para>
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

            }

            /// <summary>
            /// <para>The tolerated level of CIDR block conflict.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>REDUCED: CIDR block conflicts are allowed, but the conflicting CIDR blocks cannot be identical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REDUCED</para>
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            /// <summary>
            /// <para>The status of the CEN instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Creating</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Active</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Deleting</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the CEN instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensTags> Tags { get; set; }
            public class DescribeCensResponseBodyCensTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of CEN instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
