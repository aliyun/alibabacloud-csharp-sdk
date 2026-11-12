// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyAccountLockStateRequest : TeaModel {
        /// <summary>
        /// <para>The lock status of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UnLock</b>: Unlocked.</description></item>
        /// <item><description><b>Lock</b>: Locked.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lock</para>
        /// </summary>
        [NameInMap("AccountLockState")]
        [Validation(Required=false)]
        public string AccountLockState { get; set; }

        /// <summary>
        /// <para>The account name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_account_name</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The expiration time of the account, in the YYYY-MM-DDThh:mm:ssZ format. The account expires at the specified time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-17T10:00:00Z</para>
        /// </summary>
        [NameInMap("AccountPasswordValidTime")]
        [Validation(Required=false)]
        public string AccountPasswordValidTime { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view all clusters in the target region, including their cluster IDs.</para>
        /// </remarks>
        /// <remarks>
        /// <para>This operation is supported only for PostgreSQL clusters (DBType=PostgreSQL). Before calling this operation, you can query the DBType and DBClusterStatus by using DescribeDBClusters to confirm that the cluster is in the Running state.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
