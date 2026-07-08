// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateCloudAppInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud application, which corresponds to a unique application package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于测试使用</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Information about the patch package to upload.</para>
        /// <ol>
        /// <item><description><para>This parameter is not supported when PkgType is android.</para>
        /// </description></item>
        /// <item><description><para>For the same AppId, only one patch can be in the process of uploading at a time. This means only one patch can be in a state other than its desired state.</para>
        /// </description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Patch")]
        [Validation(Required=false)]
        public string PatchShrink { get; set; }

        /// <summary>
        /// <para>The tags for the cloud application. You can select multiple tags. This action resets all existing tags for the cloud application.</para>
        /// <ol>
        /// <item><description><para>Valid values:
        /// hot, game, and app.</para>
        /// </description></item>
        /// <item><description><para>Special case:
        /// To delete all tags, enter [&quot;NULL&quot;].</para>
        /// </description></item>
        /// </ol>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public string PkgLabelsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the stable patch. This patch is used by default if you do not specify a PatchId when the application is in use, such as during a session startup. This parameter is not supported when PkgType is android.
        /// Special value:</para>
        /// <ol>
        /// <item><description>If you set this parameter to origin, the patch version is removed and the initial version is used.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("StablePatchId")]
        [Validation(Required=false)]
        public string StablePatchId { get; set; }

    }

}
