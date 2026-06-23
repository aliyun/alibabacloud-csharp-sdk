// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachDatabaseAccountsToUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>An array of database objects.</para>
        /// <remarks>
        /// <para>You can specify up to 10 databases and 10 database accounts. If you do not specify any database accounts, permissions are granted on the entire database.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<AttachDatabaseAccountsToUserGroupRequestDatabases> Databases { get; set; }
        public class AttachDatabaseAccountsToUserGroupRequestDatabases : TeaModel {
            /// <summary>
            /// <para>An array of database account IDs.</para>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The ID of the database instance on which you want to grant permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>58</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-zvp282aly06</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user group to which to grant the permissions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
