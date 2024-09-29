// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class CreateResourceAccountRequest : TeaModel {
        /// <summary>
        /// <para>The prefix for the Alibaba Cloud account name of the member. If you leave this parameter empty, the system randomly generates a prefix.</para>
        /// <para>The prefix must be 2 to 37 characters in length.</para>
        /// <para>The prefix can contain letters, digits, and special characters but cannot contain consecutive special characters. The prefix must start with a letter or digit and end with a letter or digit. Valid special characters include underscores (<c>_</c>), periods (.), and hyphens (<c>-</c>).</para>
        /// <para>The complete Alibaba Cloud account name of a member in a resource directory is in the @.aliyunid.com format, such as <c>alice@rd-3G****.aliyunid.com</c>.</para>
        /// <para>Each name must be unique in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("AccountNamePrefix")]
        [Validation(Required=false)]
        public string AccountNamePrefix { get; set; }

        /// <summary>
        /// <para>The display name of the member.</para>
        /// <para>The name must be 2 to 50 characters in length.</para>
        /// <para>The name can contain letters, digits, underscores (_), periods (.), hyphens (-), and spaces.</para>
        /// <para>The name must be unique in the resource directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks whether an identity type can be specified for the member. If the request does not pass the dry run, an error code is returned.</description></item>
        /// <item><description>false (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the parent folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-r23M55****</para>
        /// </summary>
        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// <para>The ID of the billing account. If you leave this parameter empty, the newly created member is used as its billing account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("PayerAccountId")]
        [Validation(Required=false)]
        public string PayerAccountId { get; set; }

        /// <summary>
        /// <para>The identity type of the member. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>resell: The member is an account for a reseller. This is the default value. A relationship is automatically established between the member and the reseller. The management account of the resource directory must be used as the billing account of the member.</description></item>
        /// <item><description>non_resell: The member is not an account for a reseller. The member is an account that is not associated with a reseller. You can directly use the account to purchase Alibaba Cloud resources. The member is used as its own billing account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for resellers at the international site (alibabacloud.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>resell</para>
        /// </summary>
        [NameInMap("ResellAccountType")]
        [Validation(Required=false)]
        public string ResellAccountType { get; set; }

        /// <summary>
        /// <para>The tag of the member.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateResourceAccountRequestTag> Tag { get; set; }
        public class CreateResourceAccountRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
