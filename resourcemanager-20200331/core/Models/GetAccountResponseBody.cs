// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the member.</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public GetAccountResponseBodyAccount Account { get; set; }
        public class GetAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>181761095690****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The display name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The status of the modification for the email address bound to the member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WAIT_MODIFY: in progress</description></item>
            /// <item><description>CANCELLED: canceled</description></item>
            /// <item><description>EXPIRED: expired</description></item>
            /// </list>
            /// <para>If the value of this parameter is empty, no modification is performed for the email address.</para>
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
            /// <para>The way in which the member joins the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>invited: The member is invited to join the resource directory.</description></item>
            /// <item><description>created: The member is directly created in the resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            /// <summary>
            /// <para>The time when the member joined the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// <para>The location of the member in the resource directory.</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The time when the member was modified.</para>
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
            /// <para>The path of the member in the resource directory.</para>
            /// </summary>
            [NameInMap("ResourceDirectoryPath")]
            [Validation(Required=false)]
            public string ResourceDirectoryPath { get; set; }

            /// <summary>
            /// <para>The status of the member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateSuccess: The member is created.</description></item>
            /// <item><description>PromoteVerifying: The upgrade of the member is being confirmed.</description></item>
            /// <item><description>PromoteFailed: The upgrade of the member fails.</description></item>
            /// <item><description>PromoteExpired: The upgrade of the member expires.</description></item>
            /// <item><description>PromoteCancelled: The upgrade of the member is canceled.</description></item>
            /// <item><description>PromoteSuccess: The member is upgraded.</description></item>
            /// <item><description>InviteSuccess: The member accepts the invitation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CreateSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags that are added to the member.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAccountResponseBodyAccountTags> Tags { get; set; }
            public class GetAccountResponseBodyAccountTags : TeaModel {
                /// <summary>
                /// <para>A tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>A tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CloudAccount: cloud account</description></item>
            /// <item><description>ResourceAccount: resource account</description></item>
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
