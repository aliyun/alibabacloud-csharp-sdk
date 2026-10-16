// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateCloudAccountRequest : TeaModel {
        /// <summary>
        /// <para>The member name.</para>
        /// <para>The name must be 2 to 50 characters in length and can contain letters, digits, underscores (_), periods (.), and hyphens (-).</para>
        /// <para>The member name must be unique within the resource directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin-****</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address used to log on to the cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The ID of the parent folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-bVaRIG****</para>
        /// </summary>
        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// <para>The ID of the settlement account. If this parameter is left empty, the current account is used for settlement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("PayerAccountId")]
        [Validation(Required=false)]
        public string PayerAccountId { get; set; }

    }

}
