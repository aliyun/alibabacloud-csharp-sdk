// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The parameter that is used to obtain the truncated part. It takes effect only when <c>IsTruncated</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B450CA1-36E8-4AA2-8461-86B42BF4CC4E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the RAM users.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUsers Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUsersUser> User { get; set; }
            public class ListUsersResponseBodyUsersUser : TeaModel {
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
                /// <para>The point in time when the RAM user was created. The time is displayed in UTC.</para>
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
                /// <para> This parameter applies only to the Alibaba Cloud China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The timestamp when the RAM user last logged on to the console.</para>
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
                /// <para> This parameter applies only to the Alibaba Cloud China site (aliyun.com).</para>
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
                /// <para>CloudSSO</para>
                /// </summary>
                [NameInMap("ProvisionType")]
                [Validation(Required=false)]
                public string ProvisionType { get; set; }

                /// <summary>
                /// <para>The status of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListUsersResponseBodyUsersUserTags Tags { get; set; }
                public class ListUsersResponseBodyUsersUserTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListUsersResponseBodyUsersUserTagsTag> Tag { get; set; }
                    public class ListUsersResponseBodyUsersUserTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oparator</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of the tag</para>
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
                /// <para>The point in time when the information about the RAM user was last modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-13T09:19:49Z</para>
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

}
