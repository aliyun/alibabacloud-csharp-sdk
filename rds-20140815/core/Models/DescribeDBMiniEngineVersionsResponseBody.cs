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
        /// <para>rm-uf6wjk5*****</para>
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
        /// <para>The details of the minor engine version.</para>
        /// </summary>
        [NameInMap("MinorVersionItems")]
        [Validation(Required=false)]
        public List<DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems> MinorVersionItems { get; set; }
        public class DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems : TeaModel {
            /// <summary>
            /// <para>The PostgreSQL version to which the minor engine version corresponds. For more information, see <a href="https://help.aliyun.com/document_detail/126002.html">Release notes for AliPG</a>.</para>
            /// <remarks>
            /// <para> This parameter is available only for instances that run <b>PostgreSQL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>13.6</para>
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
            /// <para>The expiration time of the minor engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20231213</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The expiration status of the minor engine version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>vaild</b></description></item>
            /// <item><description><b>expired</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> If the minor engine version is in the Offline state, the minor engine version is discontinued. In this case, ignore the expiration status. If the minor engine version is in the Online state and the expiration state is expired, the minor engine version expires. If the expiration state is vaild, the minor engine version is still in its lifecycle.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vaild</para>
            /// </summary>
            [NameInMap("ExpireStatus")]
            [Validation(Required=false)]
            public string ExpireStatus { get; set; }

            /// <summary>
            /// <para>An internal parameter. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsHotfixVersion")]
            [Validation(Required=false)]
            public bool? IsHotfixVersion { get; set; }

            /// <summary>
            /// <para>The minor engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_20220731</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The RDS edition of the instance that runs the minor engine version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
            /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
            /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
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
            /// <item><description><b>LTS</b>: a long-term version</description></item>
            /// <item><description><b>BETA</b>: a preview version</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BETA</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The status of the minor engine version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Offline</b>: discontinued</description></item>
            /// <item><description><b>Online</b>: available</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the minor engine version is in the Offline state, the minor engine version is discontinued. In this case, ignore the expiration status. If the minor engine version is in the Online state and the expiration state is expired, the minor engine version expires. If the expiration state is vaild, the minor engine version is still in its lifecycle.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The tag that corresponds to the minor engine version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pgsql_docker_image</b>: tag of common instances</description></item>
            /// <item><description><b>pgsql_babelfish_image</b>: tag of instances for which Babelfish is enabled</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available only for instances that run <b>PostgreSQL</b>.</para>
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
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
