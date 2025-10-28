// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AuthorizeApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can specify multiple IDs. Separate multiple IDs with semicolons (;). If you leave this parameter empty, the permissions on the application are revoked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5fdf50e8-<em><b><b>;696-</b></b></em>*</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user to be authorized. The value of the parameter is in the <c>sub-account name@primary account UID</c> format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test@133434434****</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
