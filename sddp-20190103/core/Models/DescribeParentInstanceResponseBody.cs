// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeParentInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of queried data assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeParentInstanceResponseBodyItems> Items { get; set; }
        public class DescribeParentInstanceResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The audit authorization status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Authorized.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Unauthorized.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <para>The authorization status of the data asset instance.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Unauthorized.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Authorized.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public int? AuthStatus { get; set; }

            /// <summary>
            /// <para>The time when the instance was authorized. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719882941000</para>
            /// </summary>
            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public long? AuthTime { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            /// <summary>
            /// <para>The type of the connection node. This parameter is valid only for MongoDB assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("ConnectNode")]
            [Validation(Required=false)]
            public string ConnectNode { get; set; }

            /// <summary>
            /// <para>The number of databases in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DbNum")]
            [Validation(Required=false)]
            public string DbNum { get; set; }

            /// <summary>
            /// <para>The type of the database engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MySQL</b>.</para>
            /// </description></item>
            /// <item><description><para><b>MariaDB</b>.</para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b>.</para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b>.</para>
            /// </description></item>
            /// <item><description><para><b>SQLServer</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-*******t2vz</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The storage space of the instance. This parameter is valid only for OSS assets. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>409600</para>
            /// </summary>
            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public long? InstanceSize { get; set; }

            /// <summary>
            /// <para>The name of the region. The following list describes the valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>China (Hangzhou)</b></para>
            /// </description></item>
            /// <item><description><para><b>China (Shanghai)</b></para>
            /// </description></item>
            /// <item><description><para><b>China (Beijing)</b></para>
            /// </description></item>
            /// <item><description><para><b>China (Zhangjiakou)</b></para>
            /// </description></item>
            /// <item><description><para><b>China (Shenzhen)</b></para>
            /// </description></item>
            /// <item><description><para><b>China (Guangzhou)</b></para>
            /// </description></item>
            /// <item><description><para><b>China (Hong Kong)</b></para>
            /// </description></item>
            /// <item><description><para><b>Singapore</b></para>
            /// </description></item>
            /// <item><description><para><b>US (Silicon Valley)</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The ID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>The identifier of the authorized asset. If the asset is structured data, the identifier is in the format of \<c>Instance ID.Database name\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-******xxx.**st</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The region where the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the asset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MaxCompute</b></para>
            /// </description></item>
            /// <item><description><para><b>OSS</b></para>
            /// </description></item>
            /// <item><description><para><b>ADB-MYSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>TableStore</b></para>
            /// </description></item>
            /// <item><description><para><b>RDS</b></para>
            /// </description></item>
            /// <item><description><para><b>SelfDB</b></para>
            /// </description></item>
            /// <item><description><para><b>PolarDB-X</b></para>
            /// </description></item>
            /// <item><description><para><b>PolarDB</b></para>
            /// </description></item>
            /// <item><description><para><b>ADB-PG</b></para>
            /// </description></item>
            /// <item><description><para><b>OceanBase</b></para>
            /// </description></item>
            /// <item><description><para><b>MongoDB</b></para>
            /// </description></item>
            /// <item><description><para><b>Redis</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The supported connection nodes. Multiple nodes are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary,Secondary</para>
            /// </summary>
            [NameInMap("SupportConnectNodes")]
            [Validation(Required=false)]
            public string SupportConnectNodes { get; set; }

            /// <summary>
            /// <para>The tenant ID. This parameter is valid only for OceanBase assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HB***-zh_CN</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The tenant name. This parameter is valid only for OceanBase assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The number of unconnected databases in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnConnectDbCount")]
            [Validation(Required=false)]
            public string UnConnectDbCount { get; set; }

            /// <summary>
            /// <para>The reason why one-click authorization is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine type not support</para>
            /// </summary>
            [NameInMap("UnSupportOneClickAuthReason")]
            [Validation(Required=false)]
            public string UnSupportOneClickAuthReason { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of data asset instances returned on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACEF9334-BB50-525D-8CF3-6CF504E4D1B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
