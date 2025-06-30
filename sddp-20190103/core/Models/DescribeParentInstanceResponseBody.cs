// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeParentInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>When performing a paginated query, set the current page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeParentInstanceResponseBodyItems> Items { get; set; }
        public class DescribeParentInstanceResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Audit authorization status. The values are as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Authorized</description></item>
            /// <item><description><b>0</b>: Unauthorized</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <para>Authorization status of the data asset instance.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unauthorized</description></item>
            /// <item><description><b>1</b>: Authorized</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public int? AuthStatus { get; set; }

            /// <summary>
            /// <para>Instance authorization time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719882941000</para>
            /// </summary>
            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public long? AuthTime { get; set; }

            /// <summary>
            /// <para>Instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            /// <summary>
            /// <para>Connection node type, valid only for MongoDB assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("ConnectNode")]
            [Validation(Required=false)]
            public string ConnectNode { get; set; }

            /// <summary>
            /// <para>Number of databases under the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DbNum")]
            [Validation(Required=false)]
            public string DbNum { get; set; }

            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>MariaDB</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// <item><description><b>PostgreSQL</b></description></item>
            /// <item><description><b>SQLServer</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>Description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-*******t2vz</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance space size, valid only for OSS assets. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>409600</para>
            /// </summary>
            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public long? InstanceSize { get; set; }

            /// <summary>
            /// <para>Region name. The values are as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>China (Hangzhou)</b></description></item>
            /// <item><description><b>China (Shanghai)</b></description></item>
            /// <item><description><b>China (Beijing)</b></description></item>
            /// <item><description><b>China (Zhangjiakou)</b></description></item>
            /// <item><description><b>China (Shenzhen)</b></description></item>
            /// <item><description><b>China (Guangzhou)</b></description></item>
            /// <item><description><b>China (Hong Kong)</b></description></item>
            /// <item><description><b>Singapore</b></description></item>
            /// <item><description><b>US (Silicon Valley)</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>Member account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>Identifier for the authorized asset. For structured data, it is identified by <c>instanceID.databaseName</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-******xxx.**st</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The region in which the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Asset type name. The values are as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>MaxCompute</b></description></item>
            /// <item><description><b>OSS</b></description></item>
            /// <item><description><b>ADB-MYSQL</b></description></item>
            /// <item><description><b>TableStore</b></description></item>
            /// <item><description><b>RDS</b></description></item>
            /// <item><description><b>SelfDB</b></description></item>
            /// <item><description><b>PolarDB-X</b></description></item>
            /// <item><description><b>PolarDB</b></description></item>
            /// <item><description><b>ADB-PG</b></description></item>
            /// <item><description><b>OceanBase</b></description></item>
            /// <item><description><b>MongoDB</b></description></item>
            /// <item><description><b>Redis</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>Supported connection nodes, separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary,Secondary</para>
            /// </summary>
            [NameInMap("SupportConnectNodes")]
            [Validation(Required=false)]
            public string SupportConnectNodes { get; set; }

            /// <summary>
            /// <para>Tenant ID, valid only for OceanBase assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HB***-zh_CN</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>Tenant name, valid only for OceanBase assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>Number of unconnected databases under the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnConnectDbCount")]
            [Validation(Required=false)]
            public string UnConnectDbCount { get; set; }

            /// <summary>
            /// <para>Reason for not supporting one-click authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine type not support</para>
            /// </summary>
            [NameInMap("UnSupportOneClickAuthReason")]
            [Validation(Required=false)]
            public string UnSupportOneClickAuthReason { get; set; }

        }

        /// <summary>
        /// <para>When performing a paginated query, set the maximum number of data asset instances displayed per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID of the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACEF9334-BB50-525D-8CF3-6CF504E4D1B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of data items in the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
