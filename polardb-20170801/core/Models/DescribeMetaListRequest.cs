// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeMetaListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify either the <c>BackupId</c> or <c>RestoreTime</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>Call the <a href="https://help.aliyun.com/document_detail/98102.html">DescribeBackups</a> operation to query the backup set ID.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in your account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database, such as <c>test_db</c>. If you specify this parameter, the names of all tables that can be recovered from the specified database are returned.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify only one database name at a time.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the names of all databases that can be recovered from the current backup set are returned. The names of tables in each database are not returned.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("GetDbName")]
        [Validation(Required=false)]
        public string GetDbName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0 and does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b> Default value: <b>30</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/2319132.html">DescribeDBClusterAttribute</a> to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data. Specify the time in the YYYY-MM-DDThh:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You must specify either the <c>BackupId</c> or <c>RestoreTime</c> parameter. Call the <a href="https://help.aliyun.com/document_detail/98102.html">DescribeBackups</a> operation to query the point in time for restoration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-04T01:40:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
