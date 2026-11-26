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
        /// <para>Length: up to 1024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a user.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The display name of the user.</para>
        /// <para>Length: up to 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address of the user. The email address must be unique within the directory.</para>
        /// <para>Length: up to 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:Alice@example.com">Alice@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The first name of the user.</para>
        /// <para>Length: up to 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// <para>The last name of the user.</para>
        /// <para>Length: up to 64 characters.</para>
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
        /// <item><description>Enabled (default): Enabled.</description></item>
        /// <item><description>Disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;Project&quot;,&quot;Value&quot;:&quot;Test&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateUserRequestTags> Tags { get; set; }
        public class CreateUserRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The username. It must be unique within the directory and cannot be modified.</para>
        /// <para>Format: The username can contain digits, letters, and the special characters <c>@_-.</c>.</para>
        /// <para>Length: up to 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
