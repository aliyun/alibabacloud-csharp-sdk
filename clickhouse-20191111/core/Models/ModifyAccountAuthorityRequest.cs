// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyAccountAuthorityRequest : TeaModel {
        /// <summary>
        /// <para>The database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The databases to which you want to grant permissions. Separate multiple databases with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db1</para>
        /// </summary>
        [NameInMap("AllowDatabases")]
        [Validation(Required=false)]
        public string AllowDatabases { get; set; }

        /// <summary>
        /// <para>The dictionaries to which you want to grant permissions. Separate multiple dictionaries with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt1</para>
        /// </summary>
        [NameInMap("AllowDictionaries")]
        [Validation(Required=false)]
        public string AllowDictionaries { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp108z124a8o7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant Data Definition Language (DDL) permissions to the database account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: allows DDL operations.</description></item>
        /// <item><description><b>false</b>: prohibits DDL operations.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DdlAuthority")]
        [Validation(Required=false)]
        public bool? DdlAuthority { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant Data Manipulation Language (DML) permissions to the database account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: read, write, and settings permissions.</description></item>
        /// <item><description><b>readonly,modify</b>: read and settings permissions.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DmlAuthority")]
        [Validation(Required=false)]
        public string DmlAuthority { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query region IDs.</para>
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

        /// <summary>
        /// <para>The list of all databases. Separate multiple databases with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>db1,db2</para>
        /// </summary>
        [NameInMap("TotalDatabases")]
        [Validation(Required=false)]
        public string TotalDatabases { get; set; }

        /// <summary>
        /// <para>The list of all dictionaries. Separate multiple dictionaries with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt1,dt2</para>
        /// </summary>
        [NameInMap("TotalDictionaries")]
        [Validation(Required=false)]
        public string TotalDictionaries { get; set; }

    }

}
