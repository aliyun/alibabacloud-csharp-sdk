// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteAddonReleaseRequest : TeaModel {
        /// <summary>
        /// <para>Addon name. When AddonName is provided, it will ignore the ReleaseName parameter and batch uninstall all AddonReleases belonging to the same Addon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-gpu</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>Whether to force deletion, default is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The name of the AddonRelease.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-gpu-integration-name</para>
        /// </summary>
        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

    }

}
