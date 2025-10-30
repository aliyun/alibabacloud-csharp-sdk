// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonReleasesRequest : TeaModel {
        /// <summary>
        /// <para>Addon component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-gpu</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>Parent AddonReleaseId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("parentAddonReleaseId")]
        [Validation(Required=false)]
        public string ParentAddonReleaseId { get; set; }

    }

}
