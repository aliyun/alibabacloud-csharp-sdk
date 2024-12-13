// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteAccessAssignmentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00jhtfl8thteu6uj****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to de-provision the access configuration when you remove the access permissions from the CloudSSO identity. The access configuration is used to assign the access permissions, and the identity is the only one that uses the access configuration and is associated with the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DeprovisionForLastAccessAssignmentOnAccount: de-provisions the access configuration.</description></item>
        /// <item><description>None: does not de-provision the access configuration. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("DeprovisionStrategy")]
        [Validation(Required=false)]
        public string DeprovisionStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the CloudSSO identity.</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>PrincipalType</c> to <c>User</c>, set <c>PrincipalId</c> to the ID of the CloudSSO user.</description></item>
        /// <item><description>If you set <c>PrincipalType</c> to <c>Group</c>, set <c>PrincipalId</c> to the ID of the CloudSSO group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the CloudSSO identity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User</description></item>
        /// <item><description>Group</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The ID of the task object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the task object. Set the value to RD-Account, which specifies the accounts in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
