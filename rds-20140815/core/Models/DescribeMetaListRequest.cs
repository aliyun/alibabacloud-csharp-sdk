// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMetaListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set used for the query. You can call DescribeBackups to query the backup set ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>BackupSetID</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>14***</para>
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public long? BackupSetID { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database to query. This parameter supports exact match and returns the specified database name and all tables in the database.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, a list of all databases is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb1</para>
        /// </summary>
        [NameInMap("GetDbName")]
        [Validation(Required=false)]
        public string GetDbName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: greater than <b>0</b> and up to the maximum value of Integer. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when it is specified together with <b>PageSize</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when it is specified together with <b>PageIndex</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the database to query. This parameter supports fuzzy match and returns only the matched database names without table names.</para>
        /// <remarks>
        /// <para>For example, if you specify <c>test</c>, the databases <c>testdb1</c> and <c>testdb2</c> are matched. After you identify the target database, specify the exact database name by using the <b>GetDbName</b> parameter to query all tables in the database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time used for the query. The value must be earlier than the current time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC). You can call DescribeBackups to query available time points.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-30T03:29:10Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BackupSetID</b>: Restores data from a backup set. You must also specify the <b>BackupSetID</b> parameter.</description></item>
        /// <item><description><b>RestoreTime</b>: Restores data to a point in time. You must also specify the <b>RestoreTime</b> parameter.</description></item>
        /// </list>
        /// <para>Default value: <b>BackupSetID</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupSetID</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

    }

}
