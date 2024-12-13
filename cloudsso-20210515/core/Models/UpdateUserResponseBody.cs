// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F44F02EC-70D1-5E51-8E8E-FA9AC4EF952A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the user.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public UpdateUserResponseBodyUser User { get; set; }
        public class UpdateUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The time when the user was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-26T03:03:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a user.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:AliceLee@example.com">AliceLee@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The first name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("FirstName")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <para>The last name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lee</para>
            /// </summary>
            [NameInMap("LastName")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>The type of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: The user is manually created.</description></item>
            /// <item><description>Synchronized: The user is synchronized from an external identity provider (IdP).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("ProvisionType")]
            [Validation(Required=false)]
            public string ProvisionType { get; set; }

            /// <summary>
            /// <para>The status of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The logon of the user is enabled.</description></item>
            /// <item><description>Disabled: The logon of the user is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the information about the user was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-26T07:32:32Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-00q8wbq42wiltcrk****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
