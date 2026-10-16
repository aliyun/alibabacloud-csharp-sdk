// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The member account information.</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public GetAccountResponseBodyAccount Account { get; set; }
        public class GetAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// <para>The member account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>181761095690****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The display name of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Empty: No email modification record exists.</description></item>
            /// <item><description>WAIT_MODIFY: The modification is in progress.</description></item>
            /// <item><description>CANCELLED: The modification is canceled.</description></item>
            /// <item><description>EXPIRED: The modification has expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_MODIFY</para>
            /// </summary>
            [NameInMap("EmailStatus")]
            [Validation(Required=false)]
            public string EmailStatus { get; set; }

            /// <summary>
            /// <para>The ID of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-bVaRIG****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The real-name verification information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-admin</para>
            /// </summary>
            [NameInMap("IdentityInformation")]
            [Validation(Required=false)]
            public string IdentityInformation { get; set; }

            /// <summary>
            /// <para>The method used by the member account to join the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>invited: Invited.</description></item>
            /// <item><description>created: Created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            /// <summary>
            /// <para>The time when the member account joined the resource directory. The time is displayed in UTC, as specified by RFC 3339, with Z indicating UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// <para>The location of the member account in the resource directory.</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The time when the member account was last modified. The time is displayed in UTC, as specified by RFC 3339, with Z indicating UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-k3****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The path ID (RDPath) of the member account in the resource directory.</para>
            /// </summary>
            [NameInMap("ResourceDirectoryPath")]
            [Validation(Required=false)]
            public string ResourceDirectoryPath { get; set; }

            /// <summary>
            /// <para>The join status of the member account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateSuccess: Created.</description></item>
            /// <item><description>PromoteVerifying: Upgrade is being confirmed.</description></item>
            /// <item><description>PromoteFailed: Upgrade failed.</description></item>
            /// <item><description>PromoteExpired: Upgrade expired.</description></item>
            /// <item><description>PromoteCancelled: Upgrade canceled.</description></item>
            /// <item><description>PromoteSuccess: Upgrade succeeded.</description></item>
            /// <item><description>InviteSuccess: Invitation succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CreateSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAccountResponseBodyAccountTags> Tags { get; set; }
            public class GetAccountResponseBodyAccountTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the member account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CloudAccount: Cloud account.</description></item>
            /// <item><description>ResourceAccount: Resource account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceAccount</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B34724D-54B0-4A51-B34D-4512372FE1BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
