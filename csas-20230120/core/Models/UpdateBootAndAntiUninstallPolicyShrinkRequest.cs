// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateBootAndAntiUninstallPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowReport")]
        [Validation(Required=false)]
        public bool? AllowReport { get; set; }

        [NameInMap("BlockContent")]
        [Validation(Required=false)]
        public string BlockContentShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAntiUninstall")]
        [Validation(Required=false)]
        public bool? IsAntiUninstall { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsBoot")]
        [Validation(Required=false)]
        public bool? IsBoot { get; set; }

        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        [NameInMap("WhitelistUsers")]
        [Validation(Required=false)]
        public List<string> WhitelistUsers { get; set; }

    }

}
