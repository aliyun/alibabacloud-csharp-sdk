// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachDatabaseAccountsFromUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The information about the databases from which you want to remove authorization.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DetachDatabaseAccountsFromUserGroupRequestDatabases> Databases { get; set; }
        public class DetachDatabaseAccountsFromUserGroupRequestDatabases : TeaModel {
            /// <summary>
            /// <para>The IDs of the database accounts from which you want to remove authorization.</para>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The instance ID of the database from which you want to remove authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-7mz2v120f0y</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user group from which you want to remove authorized databases and database accounts.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/204509.html">ListUserGroups</a> to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
