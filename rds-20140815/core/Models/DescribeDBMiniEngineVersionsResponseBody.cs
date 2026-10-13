// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBMiniEngineVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        /// <summary>
        /// <para>The list of minor engine versions.</para>
        /// </summary>
        [NameInMap("MinorVersionItems")]
        [Validation(Required=false)]
        public List<DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems> MinorVersionItems { get; set; }
        public class DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems : TeaModel {
            /// <summary>
            /// <para>The community minor engine version that corresponds to the minor engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7.38</para>
            /// </summary>
            [NameInMap("CommunityMinorVersion")]
            [Validation(Required=false)]
            public string CommunityMinorVersion { get; set; }

            /// <summary>
            /// <para>The database engine that corresponds to the minor engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The database engine version that corresponds to the minor engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The expiration date of the minor engine version. The date is in the YYYYMMDD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20231213</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The expiration status of the minor Milvus version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>vaild</b>: The minor Milvus version is valid.</description></item>
            /// <item><description><b>expired</b>: The minor Milvus version has expired.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the offline status is Offline, the minor Milvus version is offline and the expiration status is ignored. If the offline status is Online and the expiration status is expired, the minor Milvus version has reached its end of life. If the offline status is Online and the expiration status is vaild, the minor Milvus version is still within its lifecycle.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vaild</para>
            /// </summary>
            [NameInMap("ExpireStatus")]
            [Validation(Required=false)]
            public string ExpireStatus { get; set; }

            /// <summary>
            /// <para>An internal parameter. You can ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsHotfixVersion")]
            [Validation(Required=false)]
            public bool? IsHotfixVersion { get; set; }

            /// <summary>
            /// <para>The minor engine version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_20220731</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The instance edition that corresponds to the minor engine version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic</b>: Basic Edition.</description></item>
            /// <item><description><b>HighAvailability</b>: High-availability Edition.</description></item>
            /// <item><description><b>Finance</b>: RDS Enterprise Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HighAvailability</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The URL of the release notes for the minor engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <para>The release type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>LTS</b>: Long-term support (LTS) version.</description></item>
            /// <item><description><b>BETA</b>: Beta version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BETA</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The offline status of the minor Milvus version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Offline</b>: The minor Milvus version is offline.</description></item>
            /// <item><description><b>Online</b>: The minor Milvus version is online.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the offline status is Offline, the minor Milvus version is offline and the expiration status is ignored. If the offline status is Online and the expiration status is expired, the minor Milvus version has reached its end of life. If the offline status is Online and the expiration status is vaild, the minor Milvus version is still within its lifecycle.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>Instance tag that corresponds to the minor engine version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pgsql_docker_image</b>: Instance tag for general instances.</description></item>
            /// <item><description><b>pgsql_babelfish_image</b>: Instance tag for Babelfish-enabled instances.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only for <b>PostgreSQL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pgsql_babelfish_image</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFB6083A-7699-489B-8278-C0CB4793A96E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
