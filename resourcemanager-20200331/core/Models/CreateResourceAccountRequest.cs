// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateResourceAccountRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the account name. If you leave this parameter empty, the system randomly generates a prefix.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;The length ranges from 2 to 50 characters.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;The length ranges from 2 to 37 characters.</para>
        /// <para>Format: The prefix can contain letters, digits, and special characters such as underscores (_), periods (.), and hyphens (-). It must start and end with a letter or a digit, and cannot contain consecutive special characters.</para>
        /// <para>The format of the complete account name is <AccountNamePrefix>@<ResourceDirectoryId>.aliyunid.com. Example: alice@rd-3G****.aliyunid.com.</para>
        /// <para>The account name must be unique in the resource directory.</para>
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
        /// <para>Format: The name can contain Chinese characters, letters, digits, underscores (_), periods (.), hyphens (-), and spaces.</para>
        /// <para>The display name must be unique in the resource directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

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
        /// <para>The ID of the settlement account. If you leave this parameter empty, the newly created member pays its own bills.</para>
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
        /// <item><description>resell: reseller account. This is the default value. The created member automatically establishes a reseller relationship with your reseller. You must use the management account to pay for the new member.</description></item>
        /// <item><description>non_resell: non-reseller account. The created member is a regular Alibaba Cloud account and has no relationship with your current reseller. The account purchases resources directly from Alibaba Cloud and pays its own bills.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for reseller customers on the international site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>resell</para>
        /// </summary>
        [NameInMap("ResellAccountType")]
        [Validation(Required=false)]
        public string ResellAccountType { get; set; }

        /// <summary>
        /// <para>The tags of the member.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateResourceAccountRequestTag> Tag { get; set; }
        public class CreateResourceAccountRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
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
