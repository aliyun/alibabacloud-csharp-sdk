// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteAccessAssignmentRequest : TeaModel {
        /// <summary>
        /// <para>The access configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00jhtfl8thteu6uj****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the deployment of the access configuration provisioning when you remove the last authorization that uses the access configuration on an account in a resource directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DeprovisionForLastAccessAssignmentOnAccount: removes the deployment of the access configuration provisioning.</description></item>
        /// <item><description>None: does not remove the deployment of the access configuration provisioning. Default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("DeprovisionStrategy")]
        [Validation(Required=false)]
        public string DeprovisionStrategy { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the authorization target belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("OriginTargetId")]
        [Validation(Required=false)]
        public string OriginTargetId { get; set; }

        /// <summary>
        /// <para>The CloudSSO identity ID. Details:</para>
        /// <list type="bullet">
        /// <item><description>If PrincipalType is set to User, PrincipalId is the CloudSSO user ID.</description></item>
        /// <item><description>If PrincipalType is set to Group, PrincipalId is the CloudSSO group ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The CloudSSO identity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: user.</description></item>
        /// <item><description>Group: group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The ID of the task target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the task target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RD-Account: an account in a resource directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
