// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The description of the user.</para>
        /// <para>The description can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a user.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The display name of the user.</para>
        /// <para>The name can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address of the user. The email address must be unique within the directory.</para>
        /// <para>The email address can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:Alice@example.com">Alice@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The first name of the user.</para>
        /// <para>The name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// <para>The last name of the user.</para>
        /// <para>The name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lee</para>
        /// </summary>
        [NameInMap("LastName")]
        [Validation(Required=false)]
        public string LastName { get; set; }

        /// <summary>
        /// <para>The status of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The logon of the user is enabled. This is the default value.</description></item>
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
        /// <para>The name of the user. The name must be unique within the directory. The name cannot be changed.</para>
        /// <para>The name can contain numbers, letters, and the following special characters: <c>@_-.</c></para>
        /// <para>The name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
