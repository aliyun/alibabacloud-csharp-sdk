// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GenerateUpgradeReportForSyncCloneRequest : TeaModel {
        /// <summary>
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Cluster Edition (default)</description></item>
        /// <item><description><b>SENormal</b>: Standard Edition</description></item>
        /// </list>
        /// <para>For more information about cluster editions, see <a href="https://help.aliyun.com/document_detail/183258.html">Product editions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The creation pattern. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>MigrationFromRDS</b>: migrates data from an existing ApsaraDB RDS instance to a new PolarDB cluster. The created PolarDB cluster is in read-only mode and has binary logging enabled by default. For more information about the console operation, see <a href="https://help.aliyun.com/document_detail/121582.html">Upgrade an ApsaraDB RDS for MySQL instance to a PolarDB for MySQL cluster</a>.</para>
        /// </description></item>
        /// <item><description><para><b>UpgradeFromPolarDB</b>: performs instance migration from PolarDB. For more information about the console operation, see <a href="https://help.aliyun.com/document_detail/459712.html">Major engine version upgrade</a>.</para>
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
        /// <para>Only PolarDB for PostgreSQL (Compatible with Oracle) clusters support this parameter.</para>
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
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostgreSQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version number of the destination database DPI engine.</para>
        /// <list type="bullet">
        /// <item><description>Valid values for MySQL: <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Valid value for Oracle: <b>14</b>.</description></item>
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
        /// <para>The reserved parameter. The value is a JSON string.</para>
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
        /// <para>The source instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-k2j96w169uhu868l8</para>
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

    }

}
