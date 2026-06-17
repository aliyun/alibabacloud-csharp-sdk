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
        /// <item><description><para><b>UnLock</b>: The account is not locked.</para>
        /// </description></item>
        /// <item><description><para><b>Lock</b>: The account is locked.</para>
        /// </description></item>
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
        /// <para>The name of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_account_name</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The expiration time of the account. The time must be in the \<c>YYYY-MM-DDThh:mm:ssZ\\</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-17T10:00:00Z</para>
        /// </summary>
        [NameInMap("AccountPasswordValidTime")]
        [Validation(Required=false)]
        public string AccountPasswordValidTime { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view the details of all clusters in a region, including cluster IDs.</para>
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
