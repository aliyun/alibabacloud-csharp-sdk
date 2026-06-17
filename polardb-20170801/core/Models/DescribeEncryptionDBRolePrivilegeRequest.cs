// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeEncryptionDBRolePrivilegeRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-wz9fb5nn44u1d****</para>
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

        /// <summary>
        /// <para>The name of the role permission to query. To query multiple permissions at a time, enter multiple permission names and separate them with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeEncryptionDBRolePrivilege</a> operation to view the details of all role access policy rules for the cluster. The details include the permission names.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RolePrivilegeNameList")]
        [Validation(Required=false)]
        public string RolePrivilegeNameList { get; set; }

    }

}
