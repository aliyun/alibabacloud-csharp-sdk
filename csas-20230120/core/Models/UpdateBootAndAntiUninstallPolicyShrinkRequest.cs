// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateBootAndAntiUninstallPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Let end users submit approval requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowReport")]
        [Validation(Required=false)]
        public bool? AllowReport { get; set; }

        /// <summary>
        /// <para>Content shown in the client-side block dialog.</para>
        /// </summary>
        [NameInMap("BlockContent")]
        [Validation(Required=false)]
        public string BlockContentShrink { get; set; }

        /// <summary>
        /// <para>Enable anti-uninstall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAntiUninstall")]
        [Validation(Required=false)]
        public bool? IsAntiUninstall { get; set; }

        /// <summary>
        /// <para>Enable auto-start.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsBoot")]
        [Validation(Required=false)]
        public bool? IsBoot { get; set; }

        /// <summary>
        /// <para>List of user group IDs to which this policy applies.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>List of whitelisted users.</para>
        /// </summary>
        [NameInMap("WhitelistUsers")]
        [Validation(Required=false)]
        public List<string> WhitelistUsers { get; set; }

    }

}
