// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMetaListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set from which you want to restore data. You can call the DescribeBackups operation to query the IDs of data backup files.</para>
        /// <remarks>
        /// <para> This parameter is required when you set the <b>RestoreType</b> parameter to <b>BackupSetID</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>14358</para>
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public long? BackupSetID { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database to query. The system implements exact match based on the value of this parameter and returns the name of the matched database and the names of all tables contained in the database.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the system returns all databases that are created on the instance.</para>
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
        /// <para>The number of the page to return. Valid values: any non-zero positive integer.**** Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter only takes effect when you specify the <b>PageSize</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter only takes effect when you specify the <b>PageIndex</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the database to query. The system implements fuzzy match based on the value of this parameter and returns only the name of the matched database.</para>
        /// <remarks>
        /// <para>For example, if you set the value to <c>test</c>, the system returns <c>testdb1</c> and <c>testdb2</c>. Then, you can specify the <b>GetDbName</b> parameter to query tables in the required database.</para>
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
        /// <para>rg-acfmy*****</para>
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
        /// <para>The point in time to which you want to restore data. The specified point in time must be earlier than the current time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC. You can call the DescribeBackups operation to query the restorable time range.</para>
        /// <remarks>
        /// <para> This parameter must be specified when the <b>RestoreType</b> parameter is set to <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-30T03:29:10Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration method that you want to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BackupSetID</b>: Data is restored from the backup set. If you use this value, you must also specify the <b>BackupSetID</b> parameter.</description></item>
        /// <item><description><b>RestoreTime</b>: Data is restored to a specific point in time. If you use this value, you must also specify the <b>RestoreTime</b> parameter.</description></item>
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
