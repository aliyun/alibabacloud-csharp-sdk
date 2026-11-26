// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetSecurityInfoPreferenceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow CloudSSO users in the directory to manage their security email addresses in the CloudSSO user portal, including setting, modifying, and deleting security email addresses, and sending verification emails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: allowed.</description></item>
        /// <item><description>false: not allowed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUserManageSecurityEmail")]
        [Validation(Required=false)]
        public bool? AllowUserManageSecurityEmail { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

    }

}
