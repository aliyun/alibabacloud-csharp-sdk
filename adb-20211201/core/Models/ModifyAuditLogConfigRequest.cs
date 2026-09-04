// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>The status of SQL audit logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enables SQL audit logging.</description></item>
        /// <item><description><b>off</b>: Disables SQL audit logging.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After SQL audit logging is disabled, all SQL audit logs are deleted. Query and export the SQL audit logs before disabling SQL audit logging. For more information, see <a href="https://help.aliyun.com/document_detail/612426.html">DescribeAuditLogRecords</a>. When SQL audit logging is enabled again, audit logs are displayed starting from the most recent time that audit logging was enabled.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AuditLogStatus")]
        [Validation(Required=false)]
        public string AuditLogStatus { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> to query the IDs of all clusters in a specified region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-t4nj8619bz2w3****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The type of the compute engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>XIHE (<b>default</b>): Xihe compute engine.</description></item>
        /// <item><description>SPARK: Spark compute engine.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>XIHE</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> to query the region ID of a specified cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
