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
        /// <para>&lt;props=&quot;china&quot;&gt;Length: 2 to 50 characters.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;Length: 2 to 37 characters.</para>
        /// <para>Format: Can contain letters, digits, and special characters <c>_.-</c>. Must start and end with a letter or digit. Consecutive special characters <c>_.-</c> are not allowed.</para>
        /// <para>The full account name is in the format of <AccountNamePrefix>@<ResourceDirectoryId>.aliyunid.com. Example: <c>alice@rd-3G****.aliyunid.com</c>.</para>
        /// <para>The account name must be unique within the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("AccountNamePrefix")]
        [Validation(Required=false)]
        public string AccountNamePrefix { get; set; }

        /// <summary>
        /// <para>The display name of the member.</para>
        /// <para>Length: 2 to 50 characters.</para>
        /// <para>Format: Can contain letters, digits, underscores (_), periods (.), hyphens (-), and spaces.</para>
        /// <para>The display name must be unique within the resource directory.</para>
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
        /// <para>The ID of the billing account. If you leave this parameter empty, the newly created member pays for its own resource consumption.</para>
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
        /// <item><description>resell (default): reseller account. The created member automatically establishes a reseller relationship with your distributor. You must use the management account to pay for the new member.</description></item>
        /// <item><description>non_resell: non-reseller account. The created member is a regular Alibaba Cloud account that has no relationship with your current distributor. This account purchases resources directly from Alibaba Cloud and pays for its own resource consumption.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for China site (Chinese mainland) distributor customers.</para>
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
