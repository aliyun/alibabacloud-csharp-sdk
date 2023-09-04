// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// The description of the user.
        /// 
        /// The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The display name of the user.
        /// 
        /// The name can be up to 256 characters in length.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the user. The email address must be unique within the directory.
        /// 
        /// The email address can be up to 128 characters in length.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The first name of the user.
        /// 
        /// The name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// 
        /// The name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("LastName")]
        [Validation(Required=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The status of the user. Valid values:
        /// 
        /// *   Enabled: The logon of the user is enabled. This is the default value.
        /// *   Disabled: The logon of the user is disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The name of the user. The name must be unique within the directory. The name cannot be changed.
        /// 
        /// The name can contain numbers, letters, and the following special characters: `@_-.`
        /// 
        /// The name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
