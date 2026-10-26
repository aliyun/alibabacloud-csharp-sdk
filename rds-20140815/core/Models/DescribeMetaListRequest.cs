// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMetaListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set that is used for the query when the restoration method is based on a backup set. You can call the DescribeBackups operation to query the ID.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database to query. Exact match is used. The specific database name and all tables in the database are returned.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, a list of all databases is returned.</para>
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
        /// <para>The page number. Valid values: any integer greater than <b>0</b> and less than or equal to the maximum value of the Integer type. Default value: <b>1</b>.</para>
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
        /// <para>The name of the database to query. Fuzzy match is used. Only the matched database names are returned, and table names are not returned.</para>
        /// <remarks>
        /// <para>For example, if you specify <c>test</c>, <c>testdb1</c> and <c>testdb2</c> are matched. After you determine the target database name, you can specify the exact database name in the <b>GetDbName</b> parameter to view the information about all tables in the target database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The point in time to which you want to restore data. The specified point in time must be earlier than the current time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC. You can call the DescribeBackups operation to query the time.</para>
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
        /// <item><description><b>BackupSetID</b>: restores data based on a backup set. If you set this parameter to BackupSetID, you must also specify the <b>BackupSetID</b> parameter.</description></item>
        /// <item><description><b>RestoreTime</b>: restores data to a specific point in time. If you set this parameter to RestoreTime, you must also specify the <b>RestoreTime</b> parameter.</description></item>
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
