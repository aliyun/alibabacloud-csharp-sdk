// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BB8C44A-2862-4922-AD43-03924749173B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the RAM user.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public CreateUserResponseBodyUser User { get; set; }
        public class CreateUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a cloud computing engineer.</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The time when the RAM user was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-12T09:12:00Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The display name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the RAM user.</para>
            /// <remarks>
            /// <para>This parameter is valid only on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The last time when the RAM user logged on to the Alibaba Cloud Management Console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-12T09:12:00Z</para>
            /// </summary>
            [NameInMap("LastLoginDate")]
            [Validation(Required=false)]
            public string LastLoginDate { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the RAM user.</para>
            /// <remarks>
            /// <para>This parameter is valid only on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86-1868888****</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <para>The source of the RAM user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: The RAM user is manually created in the RAM console.</description></item>
            /// <item><description>SCIM: The RAM user is mapped by using System for Cross-domain Identity Management (SCIM).</description></item>
            /// <item><description>CloudSSO: The RAM user is mapped from a CloudSSO user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("ProvisionType")]
            [Validation(Required=false)]
            public string ProvisionType { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public CreateUserResponseBodyUserTags Tags { get; set; }
            public class CreateUserResponseBodyUserTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<CreateUserResponseBodyUserTagsTag> Tag { get; set; }
                public class CreateUserResponseBodyUserTagsTag : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>operator</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alice</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the information about the RAM user was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-12T09:12:00Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The ID of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20732900249392****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The logon name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

    }

}
