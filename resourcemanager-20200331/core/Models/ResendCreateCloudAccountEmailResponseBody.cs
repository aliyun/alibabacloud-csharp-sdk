// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ResendCreateCloudAccountEmailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the member account.</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public ResendCreateCloudAccountEmailResponseBodyAccount Account { get; set; }
        public class ResendCreateCloudAccountEmailResponseBodyAccount : TeaModel {
            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12323344****</para>
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
            /// <para>The ID of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-bVaRIG****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The way in which the member account joined the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>invited: The member account is invited to join the resource directory.</description></item>
            /// <item><description>created: The member account is directly created in the resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            /// <summary>
            /// <para>The time when the member account joined the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// <para>The time when the member account was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The account record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16950264-3f0d-4ca9-82dd-6ee7a3d33d6b</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

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
            /// <para>The status of the member account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateSuccess: The member account is created.</description></item>
            /// <item><description>CreateVerifying: The creation of the member account is under confirmation.</description></item>
            /// <item><description>CreateFailed: The member account failed to be created.</description></item>
            /// <item><description>CreateExpired: The creation of the member account expired.</description></item>
            /// <item><description>CreateCancelled: The creation of the member account is canceled.</description></item>
            /// <item><description>PromoteVerifying: The upgrade of the member account is under confirmation.</description></item>
            /// <item><description>PromoteFailed: The member account failed to be upgraded.</description></item>
            /// <item><description>PromoteExpired: The upgrade of the member account expired.</description></item>
            /// <item><description>PromoteCancelled: The upgrade of the member account is canceled.</description></item>
            /// <item><description>PromoteSuccess: The member account is upgraded.</description></item>
            /// <item><description>InviteSuccess: The owner of the member account accepted the invitation.</description></item>
            /// <item><description>Removed: The member account is removed from the resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CreateVerifying</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the member account. The value CloudAccount indicates that the member account is a cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudAccount</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B34724D-54B0-4A51-B34D-4512372FE1BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
