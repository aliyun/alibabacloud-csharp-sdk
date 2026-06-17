// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GenerateUpgradeReportForSyncCloneRequest : TeaModel {
        /// <summary>
        /// <para>The product series. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Cluster Edition (default)</para>
        /// </description></item>
        /// <item><description><para><b>SENormal</b>: Standard Edition</para>
        /// </description></item>
        /// </list>
        /// <para>See <a href="https://help.aliyun.com/document_detail/183258.html">Product series</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The creation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MigrationFromRDS</b>: Migrate data from an existing RDS instance to a new PolarDB cluster. The created PolarDB cluster is in read-only mode and has binary logging enabled by default. For operations in the console, see <a href="https://help.aliyun.com/document_detail/121582.html">Upgrade an ApsaraDB RDS for MySQL instance to PolarDB for MySQL</a>.</para>
        /// </description></item>
        /// <item><description><para><b>UpgradeFromPolarDB</b>: Upgrade and migrate data from a PolarDB cluster. See <a href="https://help.aliyun.com/document_detail/459712.html">Upgrade the major version</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MigrationFromRDS</para>
        /// </summary>
        [NameInMap("CreationOption")]
        [Validation(Required=false)]
        public string CreationOption { get; set; }

        /// <summary>
        /// <para>The name of the database. You can specify only one database name.</para>
        /// <remarks>
        /// <para>This parameter is supported only for PolarDB for PostgreSQL (Oracle Compatible) clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostgreSQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the destination database engine.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for MySQL:</para>
        /// <list type="bullet">
        /// <item><description><para><b>5.6</b></para>
        /// </description></item>
        /// <item><description><para><b>5.7</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid value for Oracle: <b>14</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// <para>A reserved parameter in the JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;targetTableMode\&quot;:2}</para>
        /// </summary>
        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-k2j96w169uhu868l8</para>
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

    }

}
