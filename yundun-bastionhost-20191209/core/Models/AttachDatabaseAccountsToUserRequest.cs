// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachDatabaseAccountsToUserRequest : TeaModel {
        /// <summary>
        /// <para>An array that consists of database objects.</para>
        /// <remarks>
        /// <para> You can specify up to 10 databases and 10 database accounts. The database accounts are not required. If you do not specify a database account, the user is authorized to manage only the databases.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<AttachDatabaseAccountsToUserRequestDatabases> Databases { get; set; }
        public class AttachDatabaseAccountsToUserRequestDatabases : TeaModel {
            /// <summary>
            /// <para>An array that consists of database account IDs.</para>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The ID of the database that you want to authorize the user to manage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the bastion host whose user you want to grant permissions.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-wwo36qbv601</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user to be authorized.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/204522.html">ListUsers</a> operation to query the user ID.</para>
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
