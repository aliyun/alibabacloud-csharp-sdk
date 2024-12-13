// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserProvisioningResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6F90F3D-4502-5877-B80B-97476F6AE2CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the RAM user provisioning.</para>
        /// </summary>
        [NameInMap("UserProvisioning")]
        [Validation(Required=false)]
        public GetUserProvisioningResponseBodyUserProvisioning UserProvisioning { get; set; }
        public class GetUserProvisioningResponseBodyUserProvisioning : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The deletion policy. The policy is used to manage synchronized users when you delete the RAM user provisioning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Delete: When you delete the RAM user provisioning, the system deletes the synchronized users.</description></item>
            /// <item><description>Keep: When you delete the RAM user provisioning, the system retains the synchronized users.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Delete</para>
            /// </summary>
            [NameInMap("DeletionStrategy")]
            [Validation(Required=false)]
            public string DeletionStrategy { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a user provisioning.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-003qew84****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The conflict handling policy. The policy is used when a RAM user has the same username as the CloudSSO user who is synchronized to RAM. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>KeepBoth: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system creates a RAM user whose username is the username of the CloudSSO user plus the suffix <c>_sso</c>.</description></item>
            /// <item><description>TakeOver: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system replaces the RAM user with the CloudSSO user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>KeepBoth</para>
            /// </summary>
            [NameInMap("DuplicationStrategy")]
            [Validation(Required=false)]
            public string DuplicationStrategy { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource directory belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639738******</para>
            /// </summary>
            [NameInMap("OwnerPk")]
            [Validation(Required=false)]
            public string OwnerPk { get; set; }

            /// <summary>
            /// <para>The identity ID of the RAM user provisioning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <c>Group</c> is returned for the <c>PrincipalType</c> parameter, the value of this parameter is the ID of a CloudSSO user group (g-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
            /// <item><description>If <c>User</c> is returned for the <c>PrincipalType</c> parameter, the value of this parameter is the ID of a CloudSSO user (u-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>g-02ha881d*****</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The identity name of the RAM user provisioning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <c>Group</c> is returned for the <c>PrincipalType</c> parameter, the value of this parameter is the name of a CloudSSO user group.</description></item>
            /// <item><description>If <c>User</c> is returned for the <c>PrincipalType</c> parameter, the value of this parameter is the name of a CloudSSO user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testGroupName</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The identity type of the RAM user provisioning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: indicates that the identity of the RAM user provisioning is a CloudSSO user.</description></item>
            /// <item><description>Group: indicates that the identity of the RAM user provisioning is a CloudSSO user group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>The status of the RAM user provisioning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the object for which you create the RAM user provisioning. The value is fixed as the ID of the member in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743382******</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the object for which you create the RAM user provisioning. The value is fixed as the name of the member in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testRdMember</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The path of the resource directory in which you create the RAM user provisioning for the member.</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The object for which you create the RAM user provisioning. The value is fixed as <c>RD-Account</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RD-Account</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:42Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the RAM user provisioning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>up-002axzhapcbz6e63****</para>
            /// </summary>
            [NameInMap("UserProvisioningId")]
            [Validation(Required=false)]
            public string UserProvisioningId { get; set; }

        }

    }

}
