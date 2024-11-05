// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachDatabaseAccountsFromUserRequest : TeaModel {
        /// <summary>
        /// <para>The databases.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DetachDatabaseAccountsFromUserRequestDatabases> Databases { get; set; }
        public class DetachDatabaseAccountsFromUserRequestDatabases : TeaModel {
            /// <summary>
            /// <para>An array that consists of database account IDs.</para>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The ID of the database on which you want to revoke permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        /// <summary>
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para>You can call the DescribeInstances operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-pe335ipfk01</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user from whom you want to revoke the permissions on databases and database accounts.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204522.html">ListUsers</a> operation to query the ID of the user.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
