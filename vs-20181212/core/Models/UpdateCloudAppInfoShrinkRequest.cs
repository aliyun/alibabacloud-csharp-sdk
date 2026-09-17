// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateCloudAppInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cloud application ID, which corresponds to a unique application package.</para>
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
        /// <para>For testing purposes</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the patch package to upload.</para>
        /// <ol>
        /// <item><description>Not supported when PkgType is set to android.</description></item>
        /// <item><description>Only one patch can be in the uploading state at a time for the same AppId (only one patch in a non-final state is allowed per AppId).</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Patch")]
        [Validation(Required=false)]
        public string PatchShrink { get; set; }

        /// <summary>
        /// <para>The cloud application labels. You can select multiple labels. This operation resets the cloud application labels.</para>
        /// <ol>
        /// <item><description>Valid values:
        ///   a. hot
        ///   b. game
        ///   c. app</description></item>
        /// <item><description>Special cases:
        ///   a. To delete all labels, set this parameter to [&quot;NULL&quot;].</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public string PkgLabelsShrink { get; set; }

        /// <summary>
        /// <para>The stable PatchId. When a PatchId is not specified during business operations (such as session startup), this PatchId is used by default. Not supported when PkgType is set to android.
        /// Special values:</para>
        /// <ol>
        /// <item><description>origin: cancels the patch version and uses the initial version by default.</description></item>
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
