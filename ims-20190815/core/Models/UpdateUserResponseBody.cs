// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B56DD42-6962-4F89-A19C-079EED1F0FE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) user information.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public UpdateUserResponseBodyUser User { get; set; }
        public class UpdateUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a cloud computing engineer.</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The time when the Resource Access Management (RAM) user was created.</para>
            /// <para>Format: RFC 3339 (UTC). Example: 2020-10-12T09:12:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-12T09:12:00Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The display name of the Resource Access Management (RAM) user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the Resource Access Management (RAM) user.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The most recent time when the Resource Access Management (RAM) user logged on to the console.</para>
            /// <para>Format: RFC 3339 (UTC). Example: 2020-10-12T09:12:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-12T09:12:00Z</para>
            /// </summary>
            [NameInMap("LastLoginDate")]
            [Validation(Required=false)]
            public string LastLoginDate { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the Resource Access Management (RAM) user.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86-1868888****</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <para>The synchronization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: The Resource Access Management (RAM) user was manually created in RAM.</description></item>
            /// <item><description>SCIM: The Resource Access Management (RAM) user was created by using the System for Cross-domain Identity Management protocol.</description></item>
            /// <item><description>CloudSSO: The user was created by using CloudSSO.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("ProvisionType")]
            [Validation(Required=false)]
            public string ProvisionType { get; set; }

            /// <summary>
            /// <para>The time when the Resource Access Management (RAM) user was last updated.</para>
            /// <para>Format: RFC 3339 (UTC). Example: 2020-10-13T09:19:49Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-13T09:19:49Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The ID of the Resource Access Management (RAM) user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20732900249392****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The logon name of the Resource Access Management (RAM) user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:new@example.onaliyun.com">new@example.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

    }

}
