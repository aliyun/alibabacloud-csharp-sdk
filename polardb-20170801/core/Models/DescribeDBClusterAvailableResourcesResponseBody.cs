// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAvailableResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available resources.</para>
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZones : TeaModel {
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
            /// <para>The list of available engines.</para>
            /// </summary>
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEngines : TeaModel {
                /// <summary>
                /// <para>The available resources.</para>
                /// </summary>
                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEnginesAvailableResources> AvailableResources { get; set; }
                public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEnginesAvailableResources : TeaModel {
                    /// <summary>
                    /// <para>The edition of the cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Normal</b>: Cluster Edition.</para>
                    /// </description></item>
                    /// <item><description><para><b>Basic</b>: Single Node Edition.</para>
                    /// </description></item>
                    /// <item><description><para><b>ArchiveNormal</b>: X-Engine.</para>
                    /// </description></item>
                    /// <item><description><para><b>NormalMultimaster</b>: Multi-master Cluster (Database/Table) Edition.</para>
                    /// </description></item>
                    /// <item><description><para><b>SENormal</b>: Standard Edition.</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Only PolarDB for MySQL supports Single Node Edition.</para>
                    /// </description></item>
                    /// <item><description><para>Only PolarDB for MySQL 8.0 supports X-Engine Edition and Multi-master Cluster (Database/Table) Edition.</para>
                    /// </description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The specifications of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polar.mysql.x4.large</para>
                    /// </summary>
                    [NameInMap("DBNodeClass")]
                    [Validation(Required=false)]
                    public string DBNodeClass { get; set; }

                }

                /// <summary>
                /// <para>The version of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql57</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

            }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2B19F698-8FFC-4918-B9E2-58D878******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
