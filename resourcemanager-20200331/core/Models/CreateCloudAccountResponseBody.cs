// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateCloudAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The member information.</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public CreateCloudAccountResponseBodyAccount Account { get; set; }
        public class CreateCloudAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12323344****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The member name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin-****</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The folder ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-bVaRIG****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The method used by the member to join the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>invited: The member is invited to join.</description></item>
            /// <item><description>created: The member is created in the resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            /// <summary>
            /// <para>The time when the member was last modified. The time is displayed in UTC, as specified by RFC 3339, with Z indicating UTC.</para>
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
            /// <para>06950264-3f0d-4ca9-82dd-6ee7a3d3****</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <para>The resource directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-k3****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The status of the member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateSuccess: The member is created.</description></item>
            /// <item><description>CreateVerifying: The creation is being confirmed.</description></item>
            /// <item><description>CreateFailed: The member failed to be created.</description></item>
            /// <item><description>CreateExpired: The creation has expired.</description></item>
            /// <item><description>CreateCancelled: The creation is canceled.</description></item>
            /// <item><description>PromoteVerifying: The upgrade is being confirmed.</description></item>
            /// <item><description>PromoteFailed: The member failed to be upgraded.</description></item>
            /// <item><description>PromoteExpired: The upgrade has expired.</description></item>
            /// <item><description>PromoteCancelled: The upgrade is canceled.</description></item>
            /// <item><description>PromoteSuccess: The member is upgraded.</description></item>
            /// <item><description>InviteSuccess: The member is invited.</description></item>
            /// <item><description>Removed: The member is removed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CreateVerifying</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The member type. The value CloudAccount indicates a cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudAccount</para>
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
