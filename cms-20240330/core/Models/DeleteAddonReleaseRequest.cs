// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteAddonReleaseRequest : TeaModel {
        /// <summary>
        /// <para>The addon name. If AddonName is specified, the ReleaseName parameter is ignored and all AddonRelease instances that belong to the same addon are uninstalled in a batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-gpu</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to force delete the addon release. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        [Obsolete]
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
