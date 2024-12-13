// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUserProvisioningEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the queried entries are truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to initiate the next request.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the <c>IsTruncated</c> parameter is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2eEMmhmLa1b7Bbj9UzCgZUGj8DpDeG5TbNknuNKNP2h84KjJRnAb7vzzSDkYNmsidnAybyJYBfnPPB6xfgw54B1Wub2KQmC8LofzqBW2Y****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D85B43D-EF98-396D-B426-837E428D2D39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

        /// <summary>
        /// <para>The RAM user provisioning events.</para>
        /// </summary>
        [NameInMap("UserProvisioningEvents")]
        [Validation(Required=false)]
        public List<ListUserProvisioningEventsResponseBodyUserProvisioningEvents> UserProvisioningEvents { get; set; }
        public class ListUserProvisioningEventsResponseBodyUserProvisioningEvents : TeaModel {
            /// <summary>
            /// <para>The creation time. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:55Z</para>
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
            /// <para>Keep</para>
            /// </summary>
            [NameInMap("DeletionStrategy")]
            [Validation(Required=false)]
            public string DeletionStrategy { get; set; }

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
            /// <para>The number of execution failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// <para>The error message that is displayed when the last execution of the RAM user provisioning event failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OperationConflict.UserProvisioning.Process.fail.ImsUserExists</para>
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// <para>The ID of the RAM user provisioning event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upe-wjKyNDmZvyZOiRcJ****</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The time at which the RAM user provisioning event was last executed. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:55Z</para>
            /// </summary>
            [NameInMap("LatestAsyncTime")]
            [Validation(Required=false)]
            public string LatestAsyncTime { get; set; }

            /// <summary>
            /// <para>The identity ID of the RAM user provisioning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If you set the <c>PrincipalType</c> parameter to <c>Group</c>, the value of this parameter is the ID of a CloudSSO user group (g-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
            /// <item><description>If you set the <c>PrincipalType</c> parameter to <c>User</c>, the value of this parameter is the ID of a CloudSSO user (u-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
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
            /// <para>exampleGroupName</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The identity type of the RAM user provisioning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: The identity of the RAM user provisioning is a CloudSSO user.</description></item>
            /// <item><description>Group: The identity of the RAM user provisioning is a CloudSSO user group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>The type of the source operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>StartProvisioning: enables the RAM user provisioning.</description></item>
            /// <item><description>DeleteProvisioning: deletes the RAM user provisioning.</description></item>
            /// <item><description>AddUserToGroup: adds a user to a user group.</description></item>
            /// <item><description>RemoveUserFromGroup: removes a user from a user group.</description></item>
            /// <item><description>UserProvisioningDeletionClearing: deletes the RAM user provisioning and clears resources in the background.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StartProvisioning</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The ID of the object for which you create the RAM user provisioning.</para>
            /// <para>The value is fixed as the ID of the account in the resource directory.````</para>
            /// 
            /// <b>Example:</b>
            /// <para>153218*******</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the object for which you create the RAM user provisioning.</para>
            /// <para>If <c>RD-Account</c> is returned, the value of this parameter is the name of the account that is used to access the instance.``</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleRdMember</para>
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
            /// <para>The modification time. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:55Z</para>
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
